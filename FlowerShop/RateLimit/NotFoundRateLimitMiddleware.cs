using System.Collections.Concurrent;

namespace FlowerShop.Web.RateLimit;

// Блокирует IP, которые получают слишком много 404 за короткое время (признак сканирования)
public class NotFoundRateLimitMiddleware : IMiddleware
{
    // ip -> (счётчик 404, время первого 404 в текущем окне)
    private readonly ConcurrentDictionary<string, (int Count, DateTime WindowStart)> _counters = new();

    // ip -> время окончания блокировки
    private readonly ConcurrentDictionary<string, DateTime> _blocked = new();

    private const int MaxNotFoundPerWindow = 15;
    private static readonly TimeSpan Window = TimeSpan.FromMinutes(1);
    private static readonly TimeSpan BlockDuration = TimeSpan.FromMinutes(10);

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        var ip = context.Connection.RemoteIpAddress?.ToString() ?? "unknown";

        if (_blocked.TryGetValue(ip, out var blockedUntil))
        {
            if (DateTime.UtcNow < blockedUntil)
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Access denied.");
                return;
            }
            _blocked.TryRemove(ip, out _);
        }

        await next(context);

        if (context.Response.StatusCode == 404)
        {
            var now = DateTime.UtcNow;
            _counters.AddOrUpdate(ip,
                _ => (1, now),
                (_, existing) =>
                {
                    if (now - existing.WindowStart > Window)
                        return (1, now);
                    return (existing.Count + 1, existing.WindowStart);
                });

            if (_counters.TryGetValue(ip, out var entry) && entry.Count >= MaxNotFoundPerWindow)
            {
                _blocked[ip] = DateTime.UtcNow.Add(BlockDuration);
                _counters.TryRemove(ip, out _);
            }
        }
    }
}

using FlowerShop.Data.Models;

namespace FlowerShop.Dto.DTOUpdate
{
    public sealed record UpdateOrderDto(Guid OrderId, string Username, DateTime PickupDate, string? DeliveryAddress, OrderStatus Status, decimal TotalAmount, List<UpdateOrderItemDto> Items);
}

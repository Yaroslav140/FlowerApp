using FlowerShop.Data.Models;

namespace FlowerShop.Dto.DTOCreate
{
    public record CreateOrderDto(Guid UserId, string? Username, string? Login, DateTime PickupDate, string? DeliveryAddress, decimal TotalAmount, OrderStatus Status, List<CreateOrderItemDto> Items);
}

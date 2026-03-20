using FlowerShop.Data.Models;

namespace FlowerShop.Dto.DTOGet
{
    public record class GetOrderDto(Guid Id, string UserName, string Login, DateTime PickupDate, string? DeliveryAddress, decimal TotalAmount, OrderStatus Status, bool CanReview, List<GetOrderItemDto> OrderItem);
}

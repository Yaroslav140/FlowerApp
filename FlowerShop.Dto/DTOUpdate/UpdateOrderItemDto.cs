using FlowerShop.Dto.DTOGet;

namespace FlowerShop.Dto.DTOUpdate
{
    public sealed record UpdateOrderItemDto(Guid? OrderItemId, Guid? BouquetId, Guid? SoftToyId, int Quantity, decimal Price);
}
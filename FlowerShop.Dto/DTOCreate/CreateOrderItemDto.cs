namespace FlowerShop.Dto.DTOCreate
{
    public record CreateOrderItemDto(Guid? BouquetId, Guid? SoftToyId, Guid? FlowerId, int Quantity, decimal Price);
}

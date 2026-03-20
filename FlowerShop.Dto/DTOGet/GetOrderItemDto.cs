namespace FlowerShop.Dto.DTOGet
{
    public record class GetOrderItemDto(Guid OrderItemId, Guid? BouquetId, Guid? SoftToyId, int Quantity, decimal Price, GetBouquetDto Bouquet, GetSoftToyDto SoftToy);
}
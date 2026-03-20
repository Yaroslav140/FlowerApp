namespace FlowerShop.Dto.DTOGet
{
    public record class GetCartItemDto(Guid? BouquetId, int Quantity, decimal PriceSnapshot);
}

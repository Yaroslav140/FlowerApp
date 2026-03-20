namespace FlowerShop.Dto.DTOGet
{
    public record class GetBouquetDto(Guid BouquetId, string Name, string Description, decimal Price, int Quantity, string ImagePath, float Rating);
}

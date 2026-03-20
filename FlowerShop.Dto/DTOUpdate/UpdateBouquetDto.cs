namespace FlowerShop.Dto.DTOUpdate
{
    public record class UpdateBouquetDto(string Name, string Description, decimal Price, int Quantity, string ImagePath);
}

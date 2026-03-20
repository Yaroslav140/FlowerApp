namespace FlowerShop.Dto.DTOCreate
{
    public record class CreateBouquetDto(string NameBouquet, decimal PriceBouquet, string DescriptionBouquet, int Quantity, string ImagePath);
}

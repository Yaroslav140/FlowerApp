namespace FlowerShop.Dto.DTOGet
{
    public record class GetSoftToyDto(Guid SoftToyId, string Name, string Description, int Quantity, decimal Price, string ImagePath, float Rating);
}

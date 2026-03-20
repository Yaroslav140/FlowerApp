namespace FlowerShop.Dto.DTOGet
{
    public record class GetFlowerDto(Guid FlowerId, string Name, string Color, string Description, decimal Price, int Quantity, string ImagePath);
}

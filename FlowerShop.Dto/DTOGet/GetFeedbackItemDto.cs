namespace FlowerShop.Dto.DTOGet
{
    public record GetFeedbackItemDto(Guid Id, float ProductRating, string ProductName, string? ProductImage, string Comment);
}

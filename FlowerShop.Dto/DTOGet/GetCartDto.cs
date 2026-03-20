namespace FlowerShop.Dto.DTOGet
{
    public record class GetCartDto(Guid CartId, Guid UserId, List<GetCartItemDto> Items);
}

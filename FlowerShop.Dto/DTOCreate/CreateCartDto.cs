using FlowerShop.Dto.DTOGet;

namespace FlowerShop.Dto.DTOCreate
{
    public record class CreateCartDto(Guid UserId, List<GetCartItemDto> ItemDtos);
}

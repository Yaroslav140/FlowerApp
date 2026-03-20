namespace FlowerShop.Dto.DTOGet
{
    public record class GetUserDto(Guid UserId, string Username, string Login, string Phone, string? CodeOrder, List<GetOrderDto> Orders);
}

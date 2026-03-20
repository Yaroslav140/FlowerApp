namespace FlowerShop.Dto.DTOUpdate
{
    public record class UpdateUserDto(Guid UserId, string? Name, string? Login, string? OldPassword, string? NewPassword);
}

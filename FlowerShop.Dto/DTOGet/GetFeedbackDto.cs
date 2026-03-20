using FlowerShop.Data.Models;

namespace FlowerShop.Dto.DTOGet
{
    public record class GetFeedbackDto(Guid Id, Guid UserId, string UserName, DateTime DateCreation, string Description, float StoreRating, List<GetFeedbackItemDto> FeedbackItems);
}

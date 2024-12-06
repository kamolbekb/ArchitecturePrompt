using N_Tier.Application.Models;
using N_Tier.Application.Models.Review;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IReviewService
{
    Task<CreateReviewResponseModel> CreateReviewAsync(CreateReviewModel createReviewModel);
    Task<Review> GetReviewAsync(Guid reviewId);
    Task<IEnumerable<ReviewResponseModel>> GetAllReviewsAsync();
    //Task<List<Review>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Review>> GetAllAsync(Options options);
    Task<PagedResult<ReviewResponseModel>> GetAllReviewsAsync(Options options);
    Task<UpdateReviewResponseModel> UpdateReviewAsync(Guid id, UpdateReviewModel updateReviewModel);
    Task<BaseResponseModel> DeleteReviewAsync(Guid id);
}
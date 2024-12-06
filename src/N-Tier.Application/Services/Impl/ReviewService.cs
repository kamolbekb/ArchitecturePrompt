using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Review;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class ReviewService : IReviewService
{
    private readonly IMapper _mapper;
    private readonly IReviewRepository _reviewRepository;

    public ReviewService(IMapper mapper, IReviewRepository reviewRepository)
    {
        _mapper = mapper;
        _reviewRepository = reviewRepository;
    }

    public async Task<CreateReviewResponseModel> CreateReviewAsync(CreateReviewModel createReviewModel)
    {
        var review = _mapper.Map<Review>(createReviewModel);
        var addedReview = await _reviewRepository.InsertAsync(review);
        return new CreateReviewResponseModel
        {
            Id = addedReview.Id,
        };
    }
    
    public async Task<Review> GetReviewAsync(Guid reviewId)
    {
        var storageReview = await _reviewRepository
            .SelectByIdAsync(reviewId);

        return await Task.FromResult(storageReview);
    }

    public async Task<IEnumerable<ReviewResponseModel>> GetAllReviewsAsync()
    {
        var reviews = _reviewRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<ReviewResponseModel>>(reviews));
    }

    public Task<PagedResult<ReviewResponseModel>> GetAllReviewsAsync(Options options)
    {
        object reviews = _reviewRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<ReviewResponseModel>>(_mapper.Map<PagedResult<ReviewResponseModel>>(reviews));
    }

    public async Task<UpdateReviewResponseModel> UpdateReviewAsync(Guid id, UpdateReviewModel updateReviewModel)
    {
        var review =  _reviewRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        review.PersonId = updateReviewModel.PersonId;
        review.Content = updateReviewModel.Content;
        review.Time = updateReviewModel.Time;
        return new UpdateReviewResponseModel()
        {
            Id = (await _reviewRepository.UpdateAsync(review)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteReviewAsync(Guid id)
    {
        var review = _reviewRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _reviewRepository.DeleteAsync(review);
        await _reviewRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
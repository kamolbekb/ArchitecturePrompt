using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Review;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class ReviewsController : ApiController
{
    private readonly IReviewService _reviewService;

    public ReviewsController (IReviewService reviewService)
    {
        _reviewService = reviewService;
    }

    [HttpGet]
    [Route ("GetReview")]
    public async Task<IActionResult> GetReviewByIdAsync(Guid reviewId)
    {
        return Ok(await _reviewService.GetReviewAsync(reviewId));
    }

    [HttpGet]
    [Route("AllReviews")]
    public async Task<IActionResult> GetReviewsAsync()
    {
        return Ok(ApiResult<IEnumerable<ReviewResponseModel>>.Success(await _reviewService.GetAllReviewsAsync()));
    }

    [HttpPost]
    [Route("AddReview")]
    public async Task<IActionResult> CreateReview(CreateReviewModel model)
    {
        return Ok(await _reviewService.CreateReviewAsync(model));
    }

    [HttpPut]
    [Route("UpdateReview")]
    public async Task<IActionResult> UpdateReview(Guid id,UpdateReviewModel model)
    {
        return Ok(await _reviewService.UpdateReviewAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteReview")]
    public async Task<IActionResult> DeleteReview(Guid reviewId)
    {
        return Ok(await _reviewService.DeleteReviewAsync(reviewId));
    }
}
using AutoMapper;
using N_Tier.Application.Models.Review;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class ReviewProfile : Profile
{
    public ReviewProfile()
    {
        CreateMap<CreateReviewModel, Review>();
        CreateMap<UpdateReviewModel, Review>();

        CreateMap<Review, ReviewResponseModel>();
    }
}
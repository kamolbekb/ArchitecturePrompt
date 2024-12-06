namespace N_Tier.Application.Models.Review;

public class CreateReviewModel
{
    public string Content { get; set; }
    public Guid PersonId { get; set; }
    public DateTime? Time { get; set; }
}

public class CreateReviewResponseModel : BaseResponseModel { }
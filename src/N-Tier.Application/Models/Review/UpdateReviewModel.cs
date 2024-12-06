namespace N_Tier.Application.Models.Review;

public class UpdateReviewModel
{
    public string Content { get; set; }
    public Guid PersonId { get; set; }
    public DateTime? Time { get; set; }
}

public class UpdateReviewResponseModel : BaseResponseModel { }

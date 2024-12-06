namespace N_Tier.Application.Models.Review;

public class ReviewResponseModel : BaseResponseModel
{
    public string Content { get; set; }
    public Guid PersonId { get; set; }
    public DateTime? Time { get; set; }
}
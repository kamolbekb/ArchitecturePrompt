namespace N_Tier.Application.Models.Guardian;

public class GuardianResponseModel : BaseResponseModel
{
    public Guid PersonId { get; set; }
    public string RelativeType { get; set; }
}
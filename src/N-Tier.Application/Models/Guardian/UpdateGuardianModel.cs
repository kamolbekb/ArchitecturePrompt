namespace N_Tier.Application.Models.Guardian;

public class UpdateGuardianModel
{
    public Guid PersonId { get; set; }
    public string RelativeType { get; set; }
}

public class UpdateGuardianResponseModel : BaseResponseModel { }

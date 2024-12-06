namespace N_Tier.Application.Models.Guardian;

public class CreateGuardianModel
{
    public Guid PersonId { get; set; }
    public string RelativeType { get; set; }
}

public class CreateGuardianResponseModel : BaseResponseModel { }
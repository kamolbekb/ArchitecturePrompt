using N_Tier.Core.Enums;

namespace N_Tier.Application.Models.Person;

public class CreatePersonModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public string Image { get; set; }
}

public class CreatePersonResponseModel : BaseResponseModel { }
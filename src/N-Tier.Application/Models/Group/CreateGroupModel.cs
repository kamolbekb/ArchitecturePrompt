namespace N_Tier.Application.Models.Group;

public class CreateGroupModel
{
    public string Title { get; set; }
    public int StudentCount { get; set; }
}

public class CreateGroupResponseModel : BaseResponseModel { }
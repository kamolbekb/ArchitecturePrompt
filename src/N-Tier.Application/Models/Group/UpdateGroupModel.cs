namespace N_Tier.Application.Models.Group;

public class UpdateGroupModel
{
    public string Title { get; set; }
    public int StudentCount { get; set; }
}

public class UpdateGroupResponseModel : BaseResponseModel { }

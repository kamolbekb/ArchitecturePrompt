namespace N_Tier.Application.Models.Group;

public class GroupResponseModel : BaseResponseModel
{
    public string Title { get; set; }
    public int StudentCount { get; set; }
    public Guid StudyProcessId { get; set; }
}
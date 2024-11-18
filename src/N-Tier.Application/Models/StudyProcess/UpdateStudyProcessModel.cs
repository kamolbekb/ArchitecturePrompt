namespace N_Tier.Application.Models.StudyProcess;

public class UpdateStudyProcessModel
{
    public Guid GroupId { get; set; }
    public Guid SubjectId { get; set; }
}

public class UpdateStudyProcessResponseModel : BaseResponseModel { }

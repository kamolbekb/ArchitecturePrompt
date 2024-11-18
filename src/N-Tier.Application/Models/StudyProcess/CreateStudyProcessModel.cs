namespace N_Tier.Application.Models.StudyProcess;

public class CreateStudyProcessModel
{
    public Guid GroupId { get; set; }
    public Guid SubjectId { get; set; }
}

public class CreateStudyProcessResponseModel : BaseResponseModel { }
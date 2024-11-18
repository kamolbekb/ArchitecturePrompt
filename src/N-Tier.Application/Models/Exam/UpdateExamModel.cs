namespace N_Tier.Application.Models.Exam;

public class UpdateExamModel
{
    public Guid SubjectId { get; set; }
    public Guid RoomId { get; set; }
    public Guid GroupId { get; set; }
}

public class UpdateExamResponseModel : BaseResponseModel { }

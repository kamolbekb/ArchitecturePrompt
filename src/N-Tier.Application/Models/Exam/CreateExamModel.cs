namespace N_Tier.Application.Models.Exam;

public class CreateExamModel
{
    public Guid SubjectId { get; set; }
    public Guid RoomId { get; set; }
    public Guid GroupId { get; set; }
}

public class CreateExamResponseModel : BaseResponseModel { }
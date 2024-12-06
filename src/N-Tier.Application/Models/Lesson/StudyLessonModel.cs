namespace N_Tier.Application.Models.Lesson;

public class LessonResponseModel : BaseResponseModel
{
    public string Title { get; set; }
    public Guid GroupId { get; set; }
    public Guid SubjectId { get; set; }
}
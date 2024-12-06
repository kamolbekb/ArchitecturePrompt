namespace N_Tier.Application.Models.Lesson;

public class UpdateLessonModel
{
    public string Title { get; set; }
    public Guid GroupId { get; set; }
    public Guid SubjectId { get; set; }
}

public class UpdateLessonResponseModel : BaseResponseModel { }

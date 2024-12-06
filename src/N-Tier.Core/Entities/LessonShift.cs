namespace N_Tier.Core.Entities;

public class LessonShift
{
    public Guid LessonId { get; set; }
    public Lesson Lesson { get; set; }
    public Guid ShiftId { get; set; }
    public Shift Shift { get; set; }
}
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Info : BaseEntity
{
    public string Content { get; set; }
    public int CountOfStudents { get; set; }
    public int CountOfTeachers { get; set; }
    public ICollection<Student> Students { get; set; }
    public ICollection<Teacher> Teachers { get; set; }
}
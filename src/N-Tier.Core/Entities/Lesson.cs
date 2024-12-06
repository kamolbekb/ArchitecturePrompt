using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Lesson : BaseEntity
{
    public string Title { get; set; }
    public Guid GroupId { get; set; }
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }
    public Group Group { get; set; }
    [NotMapped]
    [JsonIgnore]
    public ICollection<LessonShift> LessonShifts { get; set; }
}
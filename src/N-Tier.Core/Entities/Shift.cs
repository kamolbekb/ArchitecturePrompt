using System.ComponentModel.DataAnnotations.Schema;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Shift : BaseEntity
{
    public string Title { get; set; }
    public TimeSpan StartAt { get; set; }
    public TimeSpan EndAt { get; set; }
    [NotMapped]
    public ICollection<LessonShift> LessonShifts { get; set; }
}
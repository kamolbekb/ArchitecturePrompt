using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Group: BaseEntity,IAuditedEntity
{
    public string Title { get; set; }
    public int StudentCount { get; set; }
    public Guid StudyProcessId { get; set; }
    public ICollection<Student> Students { get; set; }
    public ICollection<Teacher> Teachers { get; set; }
    public ICollection<Room> Rooms { get; set; }
    public StudyProcess StudyProcess { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
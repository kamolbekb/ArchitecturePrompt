using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Exam : BaseEntity,IAuditedEntity
{
    public Guid SubjectId { get; set; }
    public Guid RoomId { get; set; }
    public Guid GroupId { get; set; }
    public Room Room { get; set; }
    public Group Group { get; set; }
    public Subject Subject { get; set; }
    public DateTime StartTimeAt { get; set; }
    public DateTime EndTimeAt { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
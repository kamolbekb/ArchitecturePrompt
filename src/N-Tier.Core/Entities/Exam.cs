using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Exam : BaseEntity
{
    public Guid SubjectId { get; set; }
    public Guid RoomId { get; set; }
    public Guid GroupId { get; set; }
    public DateTime StartTimeAt { get; set; }
    public DateTime EndTimeAt { get; set; }
    public Subject Subject { get; set; }
    public Group Group { get; set; }
    public Room Room { get; set; }
}
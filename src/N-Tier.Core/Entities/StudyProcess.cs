using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class StudyProcess : BaseEntity,IAuditedEntity
{
    public string Title { get; set; }
    public Guid GroupId { get; set; }
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }
    public Group Group { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
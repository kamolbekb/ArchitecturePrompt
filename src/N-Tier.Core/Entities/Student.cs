using N_Tier.Core.Common;
using N_Tier.Core.Enums;

namespace N_Tier.Core.Entities;

public class Student : BaseEntity,IAuditedEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public PaymentStatus Payment { get; set; }
    public Guid GroupId { get; set; }
    public Group Group { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
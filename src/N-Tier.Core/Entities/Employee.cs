using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Employee : BaseEntity,IAuditedEntity
{
    public string Position { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }
    public DateOnly HireDate { get; set; }
    [JsonIgnore]
    public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();

    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
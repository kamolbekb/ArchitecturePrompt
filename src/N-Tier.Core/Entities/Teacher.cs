using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Teacher : BaseEntity
{
    public Guid SubjectId { get; set; }
    public Guid EmployeeId { get; set; }
    public Employee Employee { get; set; }
    [JsonIgnore]
    public ICollection<Group> Groups { get; set; }
    public Subject Subject { get; set; }
}
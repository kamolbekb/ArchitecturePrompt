using System.Text.Json.Serialization;
using N_Tier.Core.Common;
using N_Tier.Core.Enums;

namespace N_Tier.Core.Entities;

public class Room : BaseEntity, IAuditedEntity
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public Shift Shift { get; set; }
    [JsonIgnore] public ICollection<Group> Groups { get; set; }
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
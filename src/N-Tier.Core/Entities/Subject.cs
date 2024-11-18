using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Subject : BaseEntity,IAuditedEntity
{
    public string Title { get; set; }
    
    public string Descriprion { get; set; }
    public Guid TeacherId { get; set; }
    public Teacher Teacher { get; set; }
    [JsonIgnore]
    public string CreatedBy { get; set; }
    public DateTime CreatedOn { get; set; }
    public string UpdatedBy { get; set; }
    public DateTime? UpdatedOn { get; set; }
}
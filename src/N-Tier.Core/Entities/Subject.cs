using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Subject : BaseEntity
{
    public string Title { get; set; }
    
    public string Descriprion { get; set; }
    public Guid TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}
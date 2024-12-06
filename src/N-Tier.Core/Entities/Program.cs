using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Program : BaseEntity
{
    public string Title { get; set; }
    public string Content { get; set; }
    public decimal Price { get; set; }
    [JsonIgnore]
    public ICollection<Student> Students { get; set; }
}
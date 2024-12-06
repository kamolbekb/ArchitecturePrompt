using System.Text.Json.Serialization;
using N_Tier.Core.Common;
using N_Tier.Core.Enums;

namespace N_Tier.Core.Entities;

public class Person : BaseEntity
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public string Image { get; set; }
    [JsonIgnore]
    public ICollection<Employee> Employees { get; set; }
    [JsonIgnore]
    public ICollection<Student> Students { get; set; }
    [JsonIgnore]
    public ICollection<Guardian> Guardians { get; set; }
}
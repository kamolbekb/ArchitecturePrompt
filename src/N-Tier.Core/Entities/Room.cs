using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using N_Tier.Core.Common;
using N_Tier.Core.Enums;

namespace N_Tier.Core.Entities;

public class Room : BaseEntity
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public Shift Shift { get; set; }
    [NotMapped]
    [JsonIgnore] public ICollection<GroupRoom> GroupRooms { get; set; }
}
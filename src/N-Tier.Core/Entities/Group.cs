using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Group : BaseEntity
{
    public string Title { get; set; }
    public int StudentCount { get; set; }
    [JsonIgnore] public ICollection<Lesson> Lessons { get; set; }
    [JsonIgnore] public ICollection<Student> Students { get; set; }
    [JsonIgnore] public ICollection<Teacher> Teachers { get; set; }
    [NotMapped]
    [JsonIgnore] public ICollection<GroupRoom> GroupRooms { get; set; }
}
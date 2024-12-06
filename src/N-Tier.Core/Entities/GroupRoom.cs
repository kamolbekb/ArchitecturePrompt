using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class GroupRoom 
{
    public Guid GroupId { get; set; } 
    public Group Group { get; set; } 

    public Guid RoomId { get; set; } 
    public Room Room { get; set; }
}
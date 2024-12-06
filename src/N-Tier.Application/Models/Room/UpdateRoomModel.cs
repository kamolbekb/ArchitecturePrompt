using N_Tier.Core.Entities;
using N_Tier.Core.Enums;

namespace N_Tier.Application.Models.Room;

public class UpdateRoomModel
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public Core.Entities.Shift Shift { get; set; }
}

public class UpdateRoomResponseModel : BaseResponseModel { }

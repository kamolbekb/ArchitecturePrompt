using N_Tier.Core.Enums;

namespace N_Tier.Application.Models.Room;

public class UpdateRoomModel
{
    public int Capacity { get; set; }
    public Shift Shift { get; set; }
}

public class UpdateRoomResponseModel : BaseResponseModel { }

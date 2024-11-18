using N_Tier.Core.Enums;

namespace N_Tier.Application.Models.Room;

public class CreateRoomModel
{
    public int Capacity { get; set; }
    public Shift Shift { get; set; }
}

public class CreateRoomResponseModel : BaseResponseModel { }
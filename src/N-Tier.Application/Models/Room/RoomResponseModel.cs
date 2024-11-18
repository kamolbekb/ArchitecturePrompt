using N_Tier.Core.Enums;

namespace N_Tier.Application.Models.Room;

public class RoomResponseModel : BaseResponseModel
{
    public int Capacity { get; set; }
    public Shift Shift { get; set; }
}
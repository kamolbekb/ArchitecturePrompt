using N_Tier.Core.Entities;

namespace N_Tier.Application.Models.Room;

public class CreateRoomModel
{
    public string Name { get; set; }
    public int Capacity { get; set; }
    public Core.Entities.Shift Shift { get; set; }
}

public class CreateRoomResponseModel : BaseResponseModel { }
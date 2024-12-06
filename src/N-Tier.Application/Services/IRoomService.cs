using N_Tier.Application.Models;
using N_Tier.Application.Models.Room;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IRoomService
{
    Task<CreateRoomResponseModel> CreateRoomAsync(CreateRoomModel createRoomModel);
    Task<Room> GetRoomAsync(Guid contactId);
    Task<IEnumerable<RoomResponseModel>> GetAllRoomsAsync();
    //Task<List<Room>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Room>> GetAllAsync(Options options);
    Task<PagedResult<RoomResponseModel>> GetAllRoomsAsync(Options options);
    Task<UpdateRoomResponseModel> UpdateRoomAsync(Guid id, UpdateRoomModel updateRoomModel);
    Task<BaseResponseModel> DeleteRoomAsync(Guid id);
}
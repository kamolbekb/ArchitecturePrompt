using N_Tier.Application.Models;
using N_Tier.Application.Models.Room;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IRoomService
{
    Task<CreateRoomResponseModel> CreateAsync(CreateRoomModel createRoomModel);

    Task<BaseResponseModel> DeleteAsync(Guid id);

    Task<IEnumerable<RoomResponseModel>> GetAllAsync();
    Task<List<Room>> GetAllWithIQueryableAsync();
    List<Room> GetAllWithIEnumerable();
    Task<PagedResult<Room>> GetAllAsync(Options options);
    Task<PagedResult<RoomResponseModel>> GetAllDTOAsync(Options options);
    Task<UpdateRoomResponseModel> UpdateAsync(Guid id, UpdateRoomModel updateRoomModel);
}
using N_Tier.Application.Models;
using N_Tier.Application.Models.Room;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services.Impl;

public class RoomService : IRoomService
{
    public Task<CreateRoomResponseModel> CreateAsync(CreateRoomModel createRoomModel)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseModel> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<RoomResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Room>> GetAllWithIQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public List<Room> GetAllWithIEnumerable()
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<Room>> GetAllAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<RoomResponseModel>> GetAllDTOAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateRoomResponseModel> UpdateAsync(Guid id, UpdateRoomModel updateRoomModel)
    {
        throw new NotImplementedException();
    }
}
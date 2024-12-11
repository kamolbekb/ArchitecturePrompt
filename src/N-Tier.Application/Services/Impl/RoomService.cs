using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Room;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class RoomService : IRoomService
{
    private readonly IMapper _mapper;
    private readonly IRoomRepository _roomRepository;

    public RoomService(IMapper mapper, IRoomRepository roomRepository)
    {
        _mapper = mapper;
        _roomRepository = roomRepository;
    }

    public async Task<CreateRoomResponseModel> CreateRoomAsync(CreateRoomModel createRoomModel)
    {
        var room = _mapper.Map<Room>(createRoomModel);
        var addedRoom = await _roomRepository.InsertAsync(room);
        return new CreateRoomResponseModel
        {
            Id = addedRoom.Id,
        };
    }
    
    public async Task<Room> GetRoomAsync(Guid roomId)
    {
        var storageRoom = await _roomRepository
            .SelectByIdAsync(roomId);

        return await Task.FromResult(storageRoom);
    }

    public async Task<IEnumerable<RoomResponseModel>> GetAllRoomsAsync()
    {
        var rooms = _roomRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<RoomResponseModel>>(rooms));
    }

    public Task<PagedResult<RoomResponseModel>> GetAllRoomsAsync(Options options)
    {
        object rooms = _roomRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<RoomResponseModel>>(_mapper.Map<PagedResult<RoomResponseModel>>(rooms));
    }

    public async Task<UpdateRoomResponseModel> UpdateRoomAsync(Guid id, UpdateRoomModel updateRoomModel)
    {
        var room =  _roomRepository.SelectAll()
            .FirstOrDefault(x => x.Id == id);
        _mapper.Map(updateRoomModel, room);
        var updatedRoom = await _roomRepository.UpdateAsync(room);
        return new UpdateRoomResponseModel()
        {
            Id = (await _roomRepository.UpdateAsync(updatedRoom)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteRoomAsync(Guid id)
    {
        var room = _roomRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _roomRepository.DeleteAsync(room);
        await _roomRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
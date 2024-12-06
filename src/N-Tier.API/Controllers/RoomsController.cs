using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Room;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class RoomsController : ApiController
{
    private readonly IRoomService _roomService;

    public RoomsController (IRoomService roomService)
    {
        _roomService = roomService;
    }

    [HttpGet]
    [Route ("GetRoom")]
    public async Task<IActionResult> GetRoomByIdAsync(Guid roomId)
    {
        return Ok(await _roomService.GetRoomAsync(roomId));
    }

    [HttpGet]
    [Route("AllRooms")]
    public async Task<IActionResult> GetRoomsAsync()
    {
        return Ok(ApiResult<IEnumerable<RoomResponseModel>>.Success(await _roomService.GetAllRoomsAsync()));
    }

    [HttpPost]
    [Route("AddRoom")]
    public async Task<IActionResult> CreateRoom(CreateRoomModel model)
    {
        return Ok(await _roomService.CreateRoomAsync(model));
    }

    [HttpPut]
    [Route("UpdateRoom")]
    public async Task<IActionResult> UpdateRoom(Guid id,UpdateRoomModel model)
    {
        return Ok(await _roomService.UpdateRoomAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteRoom")]
    public async Task<IActionResult> DeleteRoom(Guid roomId)
    {
        return Ok(await _roomService.DeleteRoomAsync(roomId));
    }
}
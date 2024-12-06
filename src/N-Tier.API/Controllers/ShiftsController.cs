using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Shift;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class ShiftsController : ApiController
{
    private readonly IShiftService _shiftService;

    public ShiftsController (IShiftService shiftService)
    {
        _shiftService = shiftService;
    }

    [HttpGet]
    [Route ("GetShift")]
    public async Task<IActionResult> GetShiftByIdAsync(Guid shiftId)
    {
        return Ok(await _shiftService.GetShiftAsync(shiftId));
    }

    [HttpGet]
    [Route("AllShifts")]
    public async Task<IActionResult> GetShiftsAsync()
    {
        return Ok(ApiResult<IEnumerable<ShiftResponseModel>>.Success(await _shiftService.GetAllShiftsAsync()));
    }

    [HttpPost]
    [Route("AddShift")]
    public async Task<IActionResult> CreateShift(CreateShiftModel model)
    {
        return Ok(await _shiftService.CreateShiftAsync(model));
    }

    [HttpPut]
    [Route("UpdateShift")]
    public async Task<IActionResult> UpdateShift(Guid id,UpdateShiftModel model)
    {
        return Ok(await _shiftService.UpdateShiftAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteShift")]
    public async Task<IActionResult> DeleteShift(Guid shiftId)
    {
        return Ok(await _shiftService.DeleteShiftAsync(shiftId));
    }
}
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Guardian;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class GuardianController : ApiController
{
    private readonly IGuardianService _guardianService;

    public GuardianController (IGuardianService guardianService)
    {
        _guardianService = guardianService;
    }

    [HttpGet]
    [Route ("GetGuardian")]
    public async Task<IActionResult> GetGuardianByIdAsync(Guid guardianId)
    {
        return Ok(await _guardianService.GetGuardianAsync(guardianId));
    }

    [HttpGet]
    [Route("AllGuardians")]
    public async Task<IActionResult> GetGuardiansAsync()
    {
        return Ok(ApiResult<IEnumerable<GuardianResponseModel>>.Success(await _guardianService.GetAllGuardiansAsync()));
    }

    [HttpPost]
    [Route("AddGuardian")]
    public async Task<IActionResult> CreateGuardian(CreateGuardianModel model)
    {
        return Ok(await _guardianService.CreateGuardianAsync(model));
    }

    [HttpPut]
    [Route("UpdateGuardian")]
    public async Task<IActionResult> UpdateGuardian(Guid id,UpdateGuardianModel model)
    {
        return Ok(await _guardianService.UpdateGuardianAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteGuardian")]
    public async Task<IActionResult> DeleteGuardian(Guid guardianId)
    {
        return Ok(await _guardianService.DeleteGuardianAsync(guardianId));
    }
}
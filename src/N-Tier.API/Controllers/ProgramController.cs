using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Program;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class ProgramController : ApiController
{
    private readonly IProgramService _programService;

    public ProgramController (IProgramService programService)
    {
        _programService = programService;
    }

    [HttpGet]
    [Route ("GetProgram")]
    public async Task<IActionResult> GetProgramByIdAsync(Guid programId)
    {
        return Ok(await _programService.GetProgramAsync(programId));
    }

    [HttpGet]
    [Route("AllPrograms")]
    public async Task<IActionResult> GetProgramsAsync()
    {
        return Ok(ApiResult<IEnumerable<ProgramResponseModel>>.Success(await _programService.GetAllProgramsAsync()));
    }

    [HttpPost]
    [Route("AddProgram")]
    public async Task<IActionResult> CreateProgram(CreateProgramModel model)
    {
        return Ok(await _programService.CreateProgramAsync(model));
    }

    [HttpPut]
    [Route("UpdateProgram")]
    public async Task<IActionResult> UpdateProgram(Guid id,UpdateProgramModel model)
    {
        return Ok(await _programService.UpdateProgramAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteProgram")]
    public async Task<IActionResult> DeleteProgram(Guid programId)
    {
        return Ok(await _programService.DeleteProgramAsync(programId));
    }
}
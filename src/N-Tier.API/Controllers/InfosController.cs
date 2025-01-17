using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Info;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
public class InfosController : ApiController
{
    private readonly IInfoService _infoService;

    public InfosController (IInfoService infoService)
    {
        _infoService = infoService;
    }

    [HttpGet]
    [Route ("GetInfo")]
    public async Task<IActionResult> GetInfoByIdAsync(Guid infoId)
    {
        return Ok(await _infoService.GetInfoAsync(infoId));
    }

    [HttpGet]
    [Route("AllInfos")]
    [Authorize(Policy = "SuperAdminOnly")]
    //[Authorize(AuthenticationSchemes = "Bearer")]
    public async Task<IActionResult> GetInfosAsync()
    {
        return Ok(ApiResult<IEnumerable<InfoResponseModel>>.Success(await _infoService.GetAllInfoAsync()));
    }

    [HttpPost]
    [Route("AddInfo")]
    public async Task<IActionResult> CreateInfo(CreateInfoModel model)
    {
        return Ok(await _infoService.CreateInfoAsync(model));
    }

    [HttpPut]
    [Route("UpdateInfo")]
    public async Task<IActionResult> UpdateInfo(Guid id,UpdateInfoModel model)
    {
        return Ok(await _infoService.UpdateInfoAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteInfo")]
    public async Task<IActionResult> DeleteInfo(Guid infoId)
    {
        return Ok(await _infoService.DeleteInfoAsync(infoId));
    }
}
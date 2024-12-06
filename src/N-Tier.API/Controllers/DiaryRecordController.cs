using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.DiaryRecord;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[ApiController]
public class DiaryRecordController : ApiController
{
    private readonly IDiaryRecordService _diaryRecordService;

    public DiaryRecordController (IDiaryRecordService diaryRecordService)
    {
        _diaryRecordService = diaryRecordService;
    }

    [HttpGet]
    [Route ("GetDiaryRecord")]
    public async Task<IActionResult> GetDiaryRecordByIdAsync(Guid diaryRecordId)
    {
        return Ok(await _diaryRecordService.GetDiaryRecordAsync(diaryRecordId));
    }

    [HttpGet]
    [Route("AllDiaryRecords")]
    public async Task<IActionResult> GetDiaryRecordsAsync()
    {
        return Ok(ApiResult<IEnumerable<DiaryRecordResponseModel>>.Success(await _diaryRecordService.GetAllDiaryRecordsAsync()));
    }

    [HttpPost]
    [Route("AddDiaryRecord")]
    public async Task<IActionResult> CreateDiaryRecord(CreateDiaryRecordModel model)
    {
        return Ok(await _diaryRecordService.CreateDiaryRecordAsync(model));
    }

    [HttpPut]
    [Route("UpdateDiaryRecord")]
    public async Task<IActionResult> UpdateDiaryRecord(Guid id,UpdateDiaryRecordModel model)
    {
        return Ok(await _diaryRecordService.UpdateDiaryRecordAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteDiaryRecord")]
    public async Task<IActionResult> DeleteDiaryRecord(Guid diaryRecordId)
    {
        return Ok(await _diaryRecordService.DeleteDiaryRecordAsync(diaryRecordId));
    }
}
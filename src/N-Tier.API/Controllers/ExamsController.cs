using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Exam;
using N_Tier.Application.Models.Group;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class ExamsController : ApiController
{
    private readonly IExamService _examService;

    public ExamsController (IExamService examService)
    {
        _examService = examService;
    }

    [HttpGet]
    [Route ("GetExam")]
    public async Task<IActionResult> GetExamByIdAsync(Guid examId)
    {
        return Ok(await _examService.GetExamAsync(examId));
    }

    [HttpGet]
    [Route("AllExams")]
    public async Task<IActionResult> GetExamsAsync()
    {
        return Ok(ApiResult<IEnumerable<ExamResponseModel>>.Success(await _examService.GetAllExamsAsync()));
    }

    [HttpPost]
    [Route("AddExam")]
    public async Task<IActionResult> CreateExam(CreateExamModel model)
    {
        return Ok(await _examService.CreateExamAsync(model));
    }

    [HttpPut]
    [Route("UpdateExam")]
    public async Task<IActionResult> UpdateExam(Guid id,UpdateExamModel model)
    {
        return Ok(await _examService.UpdateExamAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteExam")]
    public async Task<IActionResult> DeleteExam(Guid examId)
    {
        return Ok(await _examService.DeleteExamAsync(examId));
    }
}
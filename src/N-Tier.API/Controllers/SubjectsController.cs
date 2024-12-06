using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Subject;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class SubjectsController : ApiController
{
    private readonly ISubjectService _subjectService;

    public SubjectsController (ISubjectService subjectService)
    {
        _subjectService = subjectService;
    }

    [HttpGet]
    [Route ("GetSubject")]
    public async Task<IActionResult> GetSubjectByIdAsync(Guid subjectId)
    {
        return Ok(await _subjectService.GetSubjectAsync(subjectId));
    }

    [HttpGet]
    [Route("AllSubjects")]
    public async Task<IActionResult> GetSubjectsAsync()
    {
        return Ok(ApiResult<IEnumerable<SubjectResponseModel>>.Success(await _subjectService.GetAllSubjectsAsync()));
    }

    [HttpPost]
    [Route("AddSubject")]
    public async Task<IActionResult> CreateSubject(CreateSubjectModel model)
    {
        return Ok(await _subjectService.CreateSubjectAsync(model));
    }

    [HttpPut]
    [Route("UpdateSubject")]
    public async Task<IActionResult> UpdateSubject(Guid id,UpdateSubjectModel model)
    {
        return Ok(await _subjectService.UpdateSubjectAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteSubject")]
    public async Task<IActionResult> DeleteSubject(Guid subjectId)
    {
        return Ok(await _subjectService.DeleteSubjectAsync(subjectId));
    }
}
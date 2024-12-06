using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Teacher;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class TeachersController : ApiController
{
    private readonly ITeacherService _teacherService;

    public TeachersController (ITeacherService teacherService)
    {
        _teacherService = teacherService;
    }

    [HttpGet]
    [Route ("GetTeacher")]
    public async Task<IActionResult> GetTeacherByIdAsync(Guid teacherId)
    {
        return Ok(await _teacherService.GetTeacherAsync(teacherId));
    }

    [HttpGet]
    [Route("AllTeachers")]
    public async Task<IActionResult> GetTeachersAsync()
    {
        return Ok(ApiResult<IEnumerable<TeacherResponseModel>>.Success(await _teacherService.GetAllTeachersAsync()));
    }

    [HttpPost]
    [Route("AddTeacher")]
    public async Task<IActionResult> CreateTeacher(CreateTeacherModel model)
    {
        return Ok(await _teacherService.CreateTeacherAsync(model));
    }

    [HttpPut]
    [Route("UpdateTeacher")]
    public async Task<IActionResult> UpdateTeacher(Guid id,UpdateTeacherModel model)
    {
        return Ok(await _teacherService.UpdateTeacherAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteTeacher")]
    public async Task<IActionResult> DeleteTeacher(Guid teacherId)
    {
        return Ok(await _teacherService.DeleteTeacherAsync(teacherId));
    }
}
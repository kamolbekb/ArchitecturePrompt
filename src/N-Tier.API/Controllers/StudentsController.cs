using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Student;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class StudentsController : ApiController
{
    private readonly IStudentService _studentService;

    public StudentsController (IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    [Route ("GetStudent")]
    public async Task<IActionResult> GetStudentByIdAsync(Guid studentId)
    {
        return Ok(await _studentService.GetStudentAsync(studentId));
    }

    [HttpGet]
    [Route("AllStudents")]
    public async Task<IActionResult> GetStudentsAsync()
    {
        return Ok(ApiResult<IEnumerable<StudentResponseModel>>.Success(await _studentService.GetAllStudentsAsync()));
    }

    [HttpPost]
    [Route("AddStudent")]
    public async Task<IActionResult> CreateStudent(CreateStudentModel model)
    {
        return Ok(await _studentService.CreateStudentAsync(model));
    }

    [HttpPut]
    [Route("UpdateStudent")]
    public async Task<IActionResult> UpdateStudent(Guid id,UpdateStudentModel model)
    {
        return Ok(await _studentService.UpdateStudentAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteStudent")]
    public async Task<IActionResult> DeleteStudent(Guid studentId)
    {
        return Ok(await _studentService.DeleteStudentAsync(studentId));
    }
}
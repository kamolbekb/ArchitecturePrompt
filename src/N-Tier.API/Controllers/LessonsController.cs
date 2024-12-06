using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Lesson;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class LessonsController : ApiController
{
    private readonly ILessonService _lessonService;

    public LessonsController (ILessonService lessonService)
    {
        _lessonService = lessonService;
    }

    [HttpGet]
    [Route ("GetLesson")]
    public async Task<IActionResult> GetLessonByIdAsync(Guid lessonId)
    {
        return Ok(await _lessonService.GetLessonAsync(lessonId));
    }

    [HttpGet]
    [Route("AllLessons")]
    public async Task<IActionResult> GetLessonsAsync()
    {
        return Ok(ApiResult<IEnumerable<LessonResponseModel>>.Success(await _lessonService.GetAllLessonsAsync()));
    }

    [HttpPost]
    [Route("AddLesson")]
    public async Task<IActionResult> CreateLesson(CreateLessonModel model)
    {
        return Ok(await _lessonService.CreateLessonAsync(model));
    }

    [HttpPut]
    [Route("UpdateLesson")]
    public async Task<IActionResult> UpdateLesson(Guid id,UpdateLessonModel model)
    {
        return Ok(await _lessonService.UpdateLessonAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteLesson")]
    public async Task<IActionResult> DeleteLesson(Guid lessonId)
    {
        return Ok(await _lessonService.DeleteLessonAsync(lessonId));
    }
}
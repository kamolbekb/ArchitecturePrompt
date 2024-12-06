using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Question;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class QuestionController : ApiController
{
    private readonly IQuestionService _questionService;

    public QuestionController (IQuestionService questionService)
    {
        _questionService = questionService;
    }

    [HttpGet]
    [Route ("GetQuestion")]
    public async Task<IActionResult> GetQuestionByIdAsync(Guid questionId)
    {
        return Ok(await _questionService.GetQuestionAsync(questionId));
    }

    [HttpGet]
    [Route("AllQuestions")]
    public async Task<IActionResult> GetQuestionsAsync()
    {
        return Ok(ApiResult<IEnumerable<QuestionResponseModel>>.Success(await _questionService.GetAllQuestionsAsync()));
    }

    [HttpPost]
    [Route("AddQuestion")]
    public async Task<IActionResult> CreateQuestion(CreateQuestionModel model)
    {
        return Ok(await _questionService.CreateQuestionAsync(model));
    }

    [HttpPut]
    [Route("UpdateQuestion")]
    public async Task<IActionResult> UpdateQuestion(Guid id,UpdateQuestionModel model)
    {
        return Ok(await _questionService.UpdateQuestionAsync(id, model));
    }

    [HttpDelete]
    [Route("DeleteQuestion")]
    public async Task<IActionResult> DeleteQuestion(Guid questionId)
    {
        return Ok(await _questionService.DeleteQuestionAsync(questionId));
    }
}
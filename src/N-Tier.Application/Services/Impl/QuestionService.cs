using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Question;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class QuestionService : IQuestionService
{
    private readonly IMapper _mapper;
    private readonly IQuestionRepository _questionRepository;

    public QuestionService(IMapper mapper, IQuestionRepository questionRepository)
    {
        _mapper = mapper;
        _questionRepository = questionRepository;
    }

    public async Task<CreateQuestionResponseModel> CreateQuestionAsync(CreateQuestionModel createQuestionModel)
    {
        var question = _mapper.Map<Question>(createQuestionModel);
        var addedQuestion = await _questionRepository.InsertAsync(question);
        return new CreateQuestionResponseModel
        {
            Id = addedQuestion.Id,
        };
    }
    
    public async Task<Question> GetQuestionAsync(Guid questionId)
    {
        var storageQuestion = await _questionRepository
            .SelectByIdAsync(questionId);

        return await Task.FromResult(storageQuestion);
    }

    public async Task<IEnumerable<QuestionResponseModel>> GetAllQuestionsAsync()
    {
        var questions = _questionRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<QuestionResponseModel>>(questions));
    }

    public Task<PagedResult<QuestionResponseModel>> GetAllQuestionsAsync(Options options)
    {
        object questions = _questionRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<QuestionResponseModel>>(_mapper.Map<PagedResult<QuestionResponseModel>>(questions));
    }

    public async Task<UpdateQuestionResponseModel> UpdateQuestionAsync(Guid id, UpdateQuestionModel updateQuestionModel)
    {
        var question =  _questionRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        _mapper.Map(updateQuestionModel, question);
        var updatedQuestion = await _questionRepository.UpdateAsync(question);
        return new UpdateQuestionResponseModel()
        {
            Id = (await _questionRepository.UpdateAsync(updatedQuestion)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteQuestionAsync(Guid id)
    {
        var question = _questionRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _questionRepository.DeleteAsync(question);
        await _questionRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
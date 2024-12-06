using N_Tier.Application.Models;
using N_Tier.Application.Models.Question;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IQuestionService
{
    Task<CreateQuestionResponseModel> CreateQuestionAsync(CreateQuestionModel createQuestionModel);
    Task<Question> GetQuestionAsync(Guid questionId);
    Task<IEnumerable<QuestionResponseModel>> GetAllQuestionsAsync();
    //Task<List<Question>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Question>> GetAllAsync(Options options);
    Task<PagedResult<QuestionResponseModel>> GetAllQuestionsAsync(Options options);
    Task<UpdateQuestionResponseModel> UpdateQuestionAsync(Guid id, UpdateQuestionModel updateQuestionModel);
    Task<BaseResponseModel> DeleteQuestionAsync(Guid id);
}
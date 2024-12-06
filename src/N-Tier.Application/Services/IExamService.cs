using N_Tier.Application.Models;
using N_Tier.Application.Models.Exam;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IExamService
{
    Task<CreateExamResponseModel> CreateExamAsync(CreateExamModel createExamModel);
    Task<Exam> GetExamAsync(Guid examId);
    Task<IEnumerable<ExamResponseModel>> GetAllExamsAsync();
    //Task<List<Exam>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Exam>> GetAllAsync(Options options);
    Task<PagedResult<ExamResponseModel>> GetAllExamsAsync(Options options);
    Task<UpdateExamResponseModel> UpdateExamAsync(Guid id, UpdateExamModel updateExamModel);
    Task<BaseResponseModel> DeleteExamAsync(Guid id);
}
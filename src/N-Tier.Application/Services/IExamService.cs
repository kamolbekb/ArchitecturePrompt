using N_Tier.Application.Models;
using N_Tier.Application.Models.Exam;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IExamService
{
    Task<CreateExamResponseModel> CreateAsync(CreateExamModel createExamModel);

    Task<BaseResponseModel> DeleteAsync(Guid id);

    Task<IEnumerable<ExamResponseModel>> GetAllAsync();
    Task<List<Exam>> GetAllWithIQueryableAsync();
    List<Exam> GetAllWithIEnumerable();
    Task<PagedResult<Exam>> GetAllAsync(Options options);
    Task<PagedResult<ExamResponseModel>> GetAllDTOAsync(Options options);
    Task<UpdateExamResponseModel> UpdateAsync(Guid id, UpdateExamModel updateTodoListModel);
}
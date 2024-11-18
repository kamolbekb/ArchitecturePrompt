using N_Tier.Application.Models;
using N_Tier.Application.Models.Exam;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services.Impl;

public class ExamService : IExamService
{
    public Task<CreateExamResponseModel> CreateAsync(CreateExamModel createExamModel)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseModel> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<ExamResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Exam>> GetAllWithIQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public List<Exam> GetAllWithIEnumerable()
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<Exam>> GetAllAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<ExamResponseModel>> GetAllDTOAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateExamResponseModel> UpdateAsync(Guid id, UpdateExamModel updateTodoListModel)
    {
        throw new NotImplementedException();
    }
}
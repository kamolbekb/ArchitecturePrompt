using N_Tier.Application.Models;
using N_Tier.Application.Models.Subject;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services.Impl;

public class SubjectService : ISubjectService
{
    public Task<CreateSubjectResponseModel> CreateAsync(CreateSubjectModel createSubjectModel)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseModel> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<SubjectResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Subject>> GetAllWithIQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public List<Subject> GetAllWithIEnumerable()
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<Subject>> GetAllAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<SubjectResponseModel>> GetAllDTOAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateSubjectResponseModel> UpdateAsync(Guid id, UpdateSubjectModel updateSubjectModel)
    {
        throw new NotImplementedException();
    }
}
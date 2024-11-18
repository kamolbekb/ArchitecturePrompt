using N_Tier.Application.Models;
using N_Tier.Application.Models.StudyProcess;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services.Impl;

public class StudyProcessService : IStudyProcessService
{
    public Task<CreateStudyProcessResponseModel> CreateAsync(CreateStudyProcessModel createStudyProcessModel)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseModel> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudyProcessResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<StudyProcess>> GetAllWithIQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public List<StudyProcess> GetAllWithIEnumerable()
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<StudyProcess>> GetAllAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<StudyProcessResponseModel>> GetAllDTOAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateStudyProcessResponseModel> UpdateAsync(Guid id, UpdateStudyProcessModel updateStudyProcessModel)
    {
        throw new NotImplementedException();
    }
}
using N_Tier.Application.Models;
using N_Tier.Application.Models.StudyProcess;
using N_Tier.Core.Entities;
namespace N_Tier.Application.Services;

public interface IStudyProcessService
{
    Task<CreateStudyProcessResponseModel> CreateAsync(CreateStudyProcessModel createStudyProcessModel);

    Task<BaseResponseModel> DeleteAsync(Guid id);

    Task<IEnumerable<StudyProcessResponseModel>> GetAllAsync();
    Task<List<StudyProcess>> GetAllWithIQueryableAsync();
    List<StudyProcess> GetAllWithIEnumerable();
    Task<PagedResult<StudyProcess>> GetAllAsync(Options options);
    Task<PagedResult<StudyProcessResponseModel>> GetAllDTOAsync(Options options);
    Task<UpdateStudyProcessResponseModel> UpdateAsync(Guid id, UpdateStudyProcessModel updateStudyProcessModel);
}
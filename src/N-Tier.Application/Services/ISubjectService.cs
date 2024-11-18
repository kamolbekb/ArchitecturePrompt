using N_Tier.Application.Models;
using N_Tier.Application.Models.Subject;
using N_Tier.Core.Entities;
namespace N_Tier.Application.Services;

public interface ISubjectService
{
    Task<CreateSubjectResponseModel> CreateAsync(CreateSubjectModel createSubjectModel);

    Task<BaseResponseModel> DeleteAsync(Guid id);

    Task<IEnumerable<SubjectResponseModel>> GetAllAsync();
    Task<List<Subject>> GetAllWithIQueryableAsync();
    List<Subject> GetAllWithIEnumerable();
    Task<PagedResult<Subject>> GetAllAsync(Options options);
    Task<PagedResult<SubjectResponseModel>> GetAllDTOAsync(Options options);
    Task<UpdateSubjectResponseModel> UpdateAsync(Guid id, UpdateSubjectModel updateSubjectModel);
}
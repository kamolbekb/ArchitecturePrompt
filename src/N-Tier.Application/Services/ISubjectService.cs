using N_Tier.Application.Models;
using N_Tier.Application.Models.Subject;
using N_Tier.Core.Entities;
namespace N_Tier.Application.Services;

public interface ISubjectService
{
    Task<CreateSubjectResponseModel> CreateSubjectAsync(CreateSubjectModel createSubjectModel);
    Task<Subject> GetSubjectAsync(Guid subjectId);
    Task<IEnumerable<SubjectResponseModel>> GetAllSubjectsAsync();
    //Task<List<Subject>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Subject>> GetAllAsync(Options options);
    Task<PagedResult<SubjectResponseModel>> GetAllSubjectsAsync(Options options);
    Task<UpdateSubjectResponseModel> UpdateSubjectAsync(Guid id, UpdateSubjectModel updateSubjectModel);
    Task<BaseResponseModel> DeleteSubjectAsync(Guid id);
}
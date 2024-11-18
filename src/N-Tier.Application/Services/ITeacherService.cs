using N_Tier.Application.Models;
using N_Tier.Application.Models.Teacher;
using N_Tier.Core.Entities;
namespace N_Tier.Application.Services;

public interface ITeacherService
{
    Task<CreateTeacherResponseModel> CreateAsync(CreateTeacherModel createTeacherModel);

    Task<BaseResponseModel> DeleteAsync(Guid id);

    Task<IEnumerable<TeacherResponseModel>> GetAllAsync();
    Task<List<Teacher>> GetAllWithIQueryableAsync();
    List<Teacher> GetAllWithIEnumerable();
    Task<PagedResult<Teacher>> GetAllAsync(Options options);
    Task<PagedResult<TeacherResponseModel>> GetAllDTOAsync(Options options);
    Task<UpdateTeacherResponseModel> UpdateAsync(Guid id, UpdateTeacherModel updateTeacherModel);
}
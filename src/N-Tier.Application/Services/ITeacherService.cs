using N_Tier.Application.Models;
using N_Tier.Application.Models.Teacher;
using N_Tier.Core.Entities;
namespace N_Tier.Application.Services;

public interface ITeacherService
{
    Task<CreateTeacherResponseModel> CreateTeacherAsync(CreateTeacherModel createTeacherModel);
    Task<Teacher> GetTeacherAsync(Guid teacherId);
    Task<IEnumerable<TeacherResponseModel>> GetAllTeachersAsync();
    //Task<List<Teacher>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Teacher>> GetAllAsync(Options options);
    Task<PagedResult<TeacherResponseModel>> GetAllTeachersAsync(Options options);
    Task<UpdateTeacherResponseModel> UpdateTeacherAsync(Guid id, UpdateTeacherModel updateTeacherModel);
    Task<BaseResponseModel> DeleteTeacherAsync(Guid id);
}
using N_Tier.Application.Models;
using N_Tier.Application.Models.Student;
using N_Tier.Core.Entities;
namespace N_Tier.Application.Services;

public interface IStudentService
{
    Task<CreateStudentResponseModel> CreateAsync(CreateStudentModel createStudentModel);

    Task<BaseResponseModel> DeleteAsync(Guid id);

    Task<IEnumerable<StudentResponseModel>> GetAllAsync();
    Task<List<Student>> GetAllWithIQueryableAsync();
    List<Student> GetAllWithIEnumerable();
    Task<PagedResult<Student>> GetAllAsync(Options options);
    Task<PagedResult<StudentResponseModel>> GetAllDTOAsync(Options options);
    Task<UpdateStudentResponseModel> UpdateAsync(Guid id, UpdateStudentModel updateStudentModel);
}
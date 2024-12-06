using N_Tier.Application.Models;
using N_Tier.Application.Models.Student;
using N_Tier.Core.Entities;
namespace N_Tier.Application.Services;

public interface IStudentService
{
    Task<CreateStudentResponseModel> CreateStudentAsync(CreateStudentModel createStudentModel);
    Task<Student> GetStudentAsync(Guid studentId);
    Task<IEnumerable<StudentResponseModel>> GetAllStudentsAsync();
    //Task<List<Student>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Student>> GetAllAsync(Options options);
    Task<PagedResult<StudentResponseModel>> GetAllStudentsAsync(Options options);
    Task<UpdateStudentResponseModel> UpdateStudentAsync(Guid id, UpdateStudentModel updateStudentModel);
    Task<BaseResponseModel> DeleteStudentAsync(Guid id);
}
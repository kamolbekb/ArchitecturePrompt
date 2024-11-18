using N_Tier.Application.Models;
using N_Tier.Application.Models.Student;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services.Impl;

public class StudentService : IStudentService
{
    public Task<CreateStudentResponseModel> CreateAsync(CreateStudentModel createStudentModel)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseModel> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<StudentResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Student>> GetAllWithIQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public List<Student> GetAllWithIEnumerable()
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<Student>> GetAllAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<StudentResponseModel>> GetAllDTOAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateStudentResponseModel> UpdateAsync(Guid id, UpdateStudentModel updateStudentModel)
    {
        throw new NotImplementedException();
    }
}
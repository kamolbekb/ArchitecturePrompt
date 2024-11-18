using N_Tier.Application.Models;
using N_Tier.Application.Models.Teacher;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services.Impl;

public class TeacherService : ITeacherService
{
    public Task<CreateTeacherResponseModel> CreateAsync(CreateTeacherModel createTeacherModel)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseModel> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<TeacherResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Teacher>> GetAllWithIQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public List<Teacher> GetAllWithIEnumerable()
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<Teacher>> GetAllAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<TeacherResponseModel>> GetAllDTOAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateTeacherResponseModel> UpdateAsync(Guid id, UpdateTeacherModel updateTeacherModel)
    {
        throw new NotImplementedException();
    }
}
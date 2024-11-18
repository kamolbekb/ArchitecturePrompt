using N_Tier.Application.Models;
using N_Tier.Application.Models.Employee;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services.Impl;

public class EmployeeService : IEmployeeService
{
    public Task<CreateEmployeeResponseModel> CreateAsync(CreateEmployeeModel createEmployeeModel)
    {
        throw new NotImplementedException();
    }

    public Task<BaseResponseModel> DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<EmployeeResponseModel>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<List<Employee>> GetAllWithIQueryableAsync()
    {
        throw new NotImplementedException();
    }

    public List<Employee> GetAllWithIEnumerable()
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<Employee>> GetAllAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<PagedResult<EmployeeResponseModel>> GetAllDTOAsync(Options options)
    {
        throw new NotImplementedException();
    }

    public Task<UpdateEmployeeResponseModel> UpdateAsync(Guid id, UpdateEmployeeModel updateEmployeeModel)
    {
        throw new NotImplementedException();
    }
}
using N_Tier.Application.Models;
using N_Tier.Application.Models.Employee;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IEmployeeService
{
    Task<CreateEmployeeResponseModel> CreateAsync(CreateEmployeeModel createEmployeeModel);

    Task<BaseResponseModel> DeleteAsync(Guid id);

    Task<IEnumerable<EmployeeResponseModel>> GetAllAsync();
    Task<List<Employee>> GetAllWithIQueryableAsync();
    List<Employee> GetAllWithIEnumerable();
    Task<PagedResult<Employee>> GetAllAsync(Options options);
    Task<PagedResult<EmployeeResponseModel>> GetAllDTOAsync(Options options);
    Task<UpdateEmployeeResponseModel> UpdateAsync(Guid id, UpdateEmployeeModel updateEmployeeModel);
}
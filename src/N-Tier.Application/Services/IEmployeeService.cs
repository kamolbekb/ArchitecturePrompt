using N_Tier.Application.Models;
using N_Tier.Application.Models.Employee;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IEmployeeService
{
    Task<CreateEmployeeResponseModel> CreateEmployeeAsync(CreateEmployeeModel createEmployeeModel);
    Task<Employee> GetEmployeeAsync(Guid id);
    Task<IEnumerable<EmployeeResponseModel>> GetAllAsync();
    //Task<List<Employee>> GetAllWithIQueryableAsync();
    //List<Employee> GetAllWithIEnumerable();
    //Task<PagedResult<Employee>> GetAllAsync(Options options);
    Task<List<Employee>> GetAllWithDetailsAsync();
    Task<UpdateEmployeeResponseModel> UpdateEmployeeAsync(Guid id, UpdateEmployeeModel updateEmployeeModel);
    Task<BaseResponseModel> DeleteEmployeeAsync(Guid id);
}

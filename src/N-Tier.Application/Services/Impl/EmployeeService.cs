using AutoMapper;
using Microsoft.Extensions.Caching.Memory;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Employee;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;
using N_Tier.Shared.Services;

namespace N_Tier.Application.Services.Impl;

public class EmployeeService : IEmployeeService
{
    //private readonly IClaimService _claimService;
    private readonly IMapper _mapper;
    private readonly IEmployeeRepository _employeeRepository;
    private readonly IPersonService _personService;

    public EmployeeService(IMapper mapper, IEmployeeRepository employeeRepository)
    {
        _mapper = mapper;
        _employeeRepository = employeeRepository;
    }

    public async Task<CreateEmployeeResponseModel> CreateEmployeeAsync(CreateEmployeeModel createEmployeeModel)
    {
        var employee = _mapper.Map<Employee>(createEmployeeModel);
        var addedEmployee = await _employeeRepository.InsertAsync(employee);
        return new CreateEmployeeResponseModel
        {
            Id = addedEmployee.Id,
        };
    }
    
    public async Task<Employee> GetEmployeeAsync(Guid employeeId)
    {
        var storageEmployee = await _employeeRepository
            .SelectByIdAsync(employeeId);

        return await Task.FromResult(storageEmployee);
    }

    public async Task<IEnumerable<EmployeeResponseModel>> GetAllAsync()
    {
        var employees = _employeeRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<EmployeeResponseModel>>(employees));
    }

    public async Task<List<Employee>> GetAllWithDetailsAsync()
    {
        return await _employeeRepository.SelectAllWithIncludesAsync("Person");
    }

    // public async Task<> GetAllIncludedAsync()
    // {
    //     
    // }
    public async Task<UpdateEmployeeResponseModel> UpdateEmployeeAsync(Guid id, UpdateEmployeeModel updateEmployeeModel)
    {
        var employee= _employeeRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        _mapper.Map(updateEmployeeModel, employee);
        var updatedEmployee = await _employeeRepository.UpdateAsync(employee);
        return new UpdateEmployeeResponseModel
        {
            Id = updatedEmployee.Id,
        }; 
    }
    
    public async Task<BaseResponseModel> DeleteEmployeeAsync(Guid id)
    {
        var employee = _employeeRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _employeeRepository.DeleteAsync(employee);
        await _employeeRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
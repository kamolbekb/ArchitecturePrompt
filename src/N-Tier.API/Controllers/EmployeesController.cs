using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Employee;
using N_Tier.Application.Services;
using N_Tier.Core.Entities;

namespace N_Tier.API.Controllers;
[AllowAnonymous]
public class EmployeesController : ApiController
{
    private readonly IEmployeeService _employeeService;
    private readonly IPersonService _personService;
    public EmployeesController(IEmployeeService employeeService, IPersonService personService)
    {
        _employeeService = employeeService;
        _personService = personService;
    }

    [HttpPost("api/employee")]
    public async Task<IActionResult> CreateEmployee(CreateEmployeeModel model)
    {
        return Ok(await _employeeService.CreateEmployeeAsync(model));
    }

    [HttpGet("api/employees/{id}")]
    public async Task<IActionResult> GetEmployee(Guid id)
    {
        return Ok(await _employeeService.GetEmployeeAsync(id));
    }

    [HttpGet("api/employees")]
    public async Task<IActionResult> GetAllEmployees()
    {
        return Ok(ApiResult<IEnumerable<EmployeeResponseModel>>.Success(await _employeeService.GetAllAsync()));
    }

    [HttpGet("api/employees/detailed")]
    public async Task<IActionResult> GetAllDetailedEmployees()
    {
        return Ok(ApiResult<List<Employee>>.Success(await _employeeService.GetAllWithDetailsAsync()));
    }

    [HttpPut("api/employees/{id}")]
    public async Task<IActionResult> UpdateEmployee(Guid id, UpdateEmployeeModel model)
    {
        return Ok(await _employeeService.UpdateEmployeeAsync(id, model));
    }

    [HttpDelete("api/employees/{id}")]
    public async Task<IActionResult> DeleteEmployee(Guid id)
    {
        return Ok(await _employeeService.DeleteEmployeeAsync(id));
    }
}
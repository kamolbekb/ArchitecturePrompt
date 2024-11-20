using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Employee;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class EmployeesController : ApiController
{
    private readonly IEmployeeService _employeeService;
}
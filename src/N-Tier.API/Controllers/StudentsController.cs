using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Student;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class StudentsController : ApiController
{
    private readonly IStudentService _studentService;
}
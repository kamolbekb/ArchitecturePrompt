using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Teacher;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class TeachersController : ApiController
{
    private readonly ITeacherService _teacherService;
}
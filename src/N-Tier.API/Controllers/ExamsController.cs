using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Group;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class ExamsController : ApiController
{
    private readonly IExamService _examService;
}
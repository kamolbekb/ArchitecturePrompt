using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.StudyProcess;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class StudyProcessesController : ApiController
{
    private readonly IStudyProcessService _studyProcessService;
}
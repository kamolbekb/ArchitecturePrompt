using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Subject;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

public class SubjectsController : ApiController
{
    private readonly ISubjectService _subjectService;
}
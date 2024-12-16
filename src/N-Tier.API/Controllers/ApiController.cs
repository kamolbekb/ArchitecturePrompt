﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace N_Tier.API.Controllers;

[ApiController]
[Authorize(Policy = "SuperAdminOnly")]
[Route("api/[controller]")]
public class ApiController : ControllerBase { }

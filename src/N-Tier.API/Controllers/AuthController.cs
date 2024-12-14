using Microsoft.AspNetCore.Mvc;
using N_Tier.Application.Models.Auth;
using N_Tier.Application.Services;

namespace N_Tier.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAccountService _accountService;

    public AuthController(IAccountService accountService)
    {
        _accountService = accountService;
    }
    [HttpPost("register")]
    public IActionResult Register([FromBody] RegisterUserRequest request)
    {
        _accountService.Register(request.UserName, request.FirstName, request.Password);
        return Ok("User created");
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginRequest loginRequest)
    {
        var token = _accountService.Login(loginRequest.UserName, loginRequest.Password);
        return Ok(token);
    }
}
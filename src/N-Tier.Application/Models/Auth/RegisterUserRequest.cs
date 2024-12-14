namespace N_Tier.Application.Models.Auth;

public record RegisterUserRequest(
    string UserName,
    string FirstName,
    string Password);

using N_Tier.Core.Entities.User;

namespace N_Tier.Application.Models.Auth;

public record RegisterUserRequest(
    string UserName,
    string FirstName,
    string Password,
    Role Role);

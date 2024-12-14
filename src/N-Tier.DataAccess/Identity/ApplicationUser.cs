using Microsoft.AspNetCore.Identity;

namespace N_Tier.DataAccess.Identity;

public class ApplicationUser : IdentityUser
{
    public string? Initials { get; set; }
}

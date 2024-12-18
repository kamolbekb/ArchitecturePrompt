using Microsoft.AspNetCore.Authorization;

namespace N_Tier.Core.Entities.User;

public sealed class HasRoleAttribute : AuthorizeAttribute
{
    public HasRoleAttribute(Role role)
        : base(policy: role.ToString())
    {
        
    }
}
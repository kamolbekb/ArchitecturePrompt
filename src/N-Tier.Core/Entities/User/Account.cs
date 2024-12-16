using N_Tier.Core.Common;

namespace N_Tier.Core.Entities.User;

public class Account : BaseEntity
{
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string PasswordHash { get; set; }
    public string Role { get; set; }
}
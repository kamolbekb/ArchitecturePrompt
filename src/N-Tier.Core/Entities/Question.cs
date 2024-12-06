using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Question : BaseEntity
{
    public string Email { get; set; }
    public string Message { get; set; }
    public DateTime? Time { get; set; }
}
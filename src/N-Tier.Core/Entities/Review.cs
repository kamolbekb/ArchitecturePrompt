using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Review : BaseEntity
{
    public string Content { get; set; }
    public Guid PersonId { get; set; }
    public DateTime? Time { get; set; }
    public Person Person { get; set; }
}
using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class Guardian : BaseEntity
{
    public Guid PersonId { get; set; }
    public string RelativeType { get; set; }
    public Person Person { get; set; }
    public ICollection<Student> Students { get; set; }
}
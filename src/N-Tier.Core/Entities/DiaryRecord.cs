using N_Tier.Core.Common;

namespace N_Tier.Core.Entities;

public class DiaryRecord : BaseEntity
{
    public DateOnly Date { get; set; }
    public decimal Score { get; set; }
    public string Comment { get; set; }
    public Guid DiaryId { get; set; }
    public Guid SubjectId { get; set; }
    public Subject Subject { get; set; }
    public Diary Diary { get; set; }
}
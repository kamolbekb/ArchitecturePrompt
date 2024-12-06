using N_Tier.Core.Common;
using N_Tier.Core.Enums;

namespace N_Tier.Core.Entities;

public class Student : BaseEntity
{
    
    public PaymentStatus Payment { get; set; }
    public Guid PersonId { get; set; }
    public Guid DiaryId { get; set; }
    public Guid GroupId { get; set; }
    public Guid GuardianId { get; set; }
    public Guid ProgramId { get; set; }
    public Person Person { get; set; }
    public Guardian Guardian { get; set; }
    public Program Program { get; set; }
    public Diary Diary { get; set; }
    public Group Group { get; set; }
}
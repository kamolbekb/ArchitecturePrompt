using N_Tier.Core.Enums;

namespace N_Tier.Application.Models.Student;

public class StudentResponseModel : BaseResponseModel
{
    public PaymentStatus Payment { get; set; }
    public Guid PersonId { get; set; }
    public Guid DiaryId { get; set; }
    public Guid GroupId { get; set; }
    public Guid GuardianId { get; set; }
    public Guid ProgramId { get; set; }
}
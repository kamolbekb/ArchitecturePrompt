using N_Tier.Core.Enums;

namespace N_Tier.Application.Models.Student;

public class UpdateStudentModel
{
    public PaymentStatus Payment { get; set; }
    public Guid PersonId { get; set; }
    public Guid DiaryId { get; set; }
    public Guid GroupId { get; set; }
    public Guid GuardianId { get; set; }
    public Guid ProgramId { get; set; }
}

public class UpdateStudentResponseModel : BaseResponseModel { }

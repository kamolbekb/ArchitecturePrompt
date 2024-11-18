using N_Tier.Core.Enums;

namespace N_Tier.Application.Models.Student;

public class UpdateStudentModel
{
    public string Name { get; set; }
    public string Email { get; set; }
    public Guid GroupId { get; set; }
    public PaymentStatus Payment { get; set; }
}

public class UpdateStudentResponseModel : BaseResponseModel { }

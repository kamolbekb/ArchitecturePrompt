namespace N_Tier.Application.Models.Teacher;

public class TeacherResponseModel : BaseResponseModel
{
    public Guid SubjectId { get; set; }
    public Guid EmployeeId { get; set; }
}
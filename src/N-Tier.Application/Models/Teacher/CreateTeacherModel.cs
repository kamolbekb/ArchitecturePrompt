namespace N_Tier.Application.Models.Teacher;

public class CreateTeacherModel
{
    public Guid SubjectId { get; set; }
    public Guid EmployeeId { get; set; }
}
public class CreateTeacherResponseModel : BaseResponseModel { }
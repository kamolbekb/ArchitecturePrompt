namespace N_Tier.Application.Models.Teacher;

public class UpdateTeacherModel
{
    public Guid SubjectId { get; set; }
    public Guid EmployeeId { get; set; }
}

public class UpdateTeacherResponseModel : BaseResponseModel { }

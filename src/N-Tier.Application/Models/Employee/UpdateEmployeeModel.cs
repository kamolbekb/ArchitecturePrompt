namespace N_Tier.Application.Models.Employee;

public class UpdateEmployeeModel
{
    public Guid PersonId { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public DateOnly HireDate { get; set; }
}

public class UpdateEmployeeResponseModel : BaseResponseModel { }

namespace N_Tier.Application.Models.Employee;

public class CreateEmployeeModel
{
    public Guid PersonId { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public DateOnly HireDate { get; set; }
}

public class CreateEmployeeResponseModel : BaseResponseModel { }
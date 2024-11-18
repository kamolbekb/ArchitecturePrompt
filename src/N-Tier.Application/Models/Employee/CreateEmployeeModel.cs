namespace N_Tier.Application.Models.Employee;

public class CreateEmployeeModel
{
    public string Position { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public double Salary { get; set; }
    public DateOnly HireDate { get; set; }
}

public class CreateEmployeeResponseModel : BaseResponseModel { }
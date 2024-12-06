namespace N_Tier.Application.Models.Employee;

public class EmployeeResponseModel : BaseResponseModel
{
    public Guid PersonId { get; set; }
    public string Position { get; set; }
    public double Salary { get; set; }
    public DateOnly HireDate { get; set; }
}
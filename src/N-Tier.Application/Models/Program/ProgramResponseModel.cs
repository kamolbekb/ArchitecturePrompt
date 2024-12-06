namespace N_Tier.Application.Models.Program;

public class ProgramResponseModel : BaseResponseModel
{
    public string Title { get; set; }
    public string Content { get; set; }
    public decimal Price { get; set; }
}
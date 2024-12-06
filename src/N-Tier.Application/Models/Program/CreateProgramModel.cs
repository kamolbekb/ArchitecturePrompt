namespace N_Tier.Application.Models.Program;

public class CreateProgramModel
{
    public string Title { get; set; }
    public string Content { get; set; }
    public decimal Price { get; set; }
}

public class CreateProgramResponseModel : BaseResponseModel { }
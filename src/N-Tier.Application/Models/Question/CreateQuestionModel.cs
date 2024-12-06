namespace N_Tier.Application.Models.Question;

public class CreateQuestionModel
{
    public string Email { get; set; }
    public string Message { get; set; }
    public DateTime? Time { get; set; }
}

public class CreateQuestionResponseModel : BaseResponseModel { }
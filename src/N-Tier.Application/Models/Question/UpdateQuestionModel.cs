namespace N_Tier.Application.Models.Question;

public class UpdateQuestionModel
{
    public string Email { get; set; }
    public string Message { get; set; }
    public DateTime? Time { get; set; }
}

public class UpdateQuestionResponseModel : BaseResponseModel { }

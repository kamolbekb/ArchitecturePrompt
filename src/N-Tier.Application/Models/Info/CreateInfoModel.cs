namespace N_Tier.Application.Models.Info;

public class CreateInfoModel
{
    public string Content { get; set; }
    public int CountOfStudents { get; set; }
    public int CountOfTeachers { get; set; }
}

public class CreateInfoResponseModel : BaseResponseModel { }
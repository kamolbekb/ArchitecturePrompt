namespace N_Tier.Application.Models.Subject;

public class CreateSubjectModel
{
    public string Title { get; set; }
    
    public string Descriprion { get; set; }
    public Guid TeacherId { get; set; }
}

public class CreateSubjectResponseModel : BaseResponseModel { }
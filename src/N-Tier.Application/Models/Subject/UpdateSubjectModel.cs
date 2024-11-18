namespace N_Tier.Application.Models.Subject;

public class UpdateSubjectModel
{
    public string Title { get; set; }
    public string Descriprion { get; set; }
    public Guid TeacherId { get; set; }
}

public class UpdateSubjectResponseModel : BaseResponseModel { }

namespace N_Tier.Application.Models.DiaryRecord;

public class CreateDiaryRecordModel
{
    public DateOnly Date { get; set; }
    public decimal Score { get; set; }
    public string Comment { get; set; }
    public Guid DiaryId { get; set; }
    public Guid SubjectId { get; set; }
}

public class CreateDiaryRecordResponseModel : BaseResponseModel { }
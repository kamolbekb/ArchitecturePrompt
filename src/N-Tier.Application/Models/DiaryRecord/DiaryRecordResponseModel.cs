namespace N_Tier.Application.Models.DiaryRecord;

public class DiaryRecordResponseModel : BaseResponseModel
{
    public DateOnly Date { get; set; }
    public decimal Score { get; set; }
    public string Comment { get; set; }
    public Guid DiaryId { get; set; }
    public Guid SubjectId { get; set; }
}
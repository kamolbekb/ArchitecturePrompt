namespace N_Tier.Application.Models.Shift;

public class CreateShiftModel
{
    public string Title { get; set; }
    public TimeSpan StartAt { get; set; }
    public TimeSpan EndAt { get; set; }
}

public class CreateShiftResponseModel : BaseResponseModel { }
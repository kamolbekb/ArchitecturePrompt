using N_Tier.Application.Models;
using N_Tier.Application.Models.DiaryRecord;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IDiaryRecordService
{
    Task<CreateDiaryRecordResponseModel> CreateDiaryRecordAsync(CreateDiaryRecordModel createDiaryRecordModel);
    Task<DiaryRecord> GetDiaryRecordAsync(Guid diaryRecordId);
    Task<IEnumerable<DiaryRecordResponseModel>> GetAllDiaryRecordsAsync();
    //Task<List<DiaryRecord>> GetAllWithIQueryableAsync();
    //Task<PagedResult<DiaryRecord>> GetAllAsync(Options options);
    Task<List<DiaryRecord>> GetAllWithDetailsAsync();
    Task<UpdateDiaryRecordResponseModel> UpdateDiaryRecordAsync(Guid id, UpdateDiaryRecordModel updateDiaryRecordModel);
    Task<BaseResponseModel> DeleteDiaryRecordAsync(Guid id);
}
using N_Tier.Application.Models;
using N_Tier.Application.Models.Diary;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IDiaryService
{
    Task<CreateDiaryResponseModel> CreateDiaryAsync(CreateDiaryModel createDiaryModel);
    Task<Diary> GetDiaryAsync(Guid diaryId);
    Task<IEnumerable<DiaryResponseModel>> GetAllDiarysAsync();
    //Task<List<Diary>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Diary>> GetAllAsync(Options options);
    Task<PagedResult<DiaryResponseModel>> GetAllDiarysAsync(Options options);
    Task<UpdateDiaryResponseModel> UpdateDiaryAsync(Guid id, UpdateDiaryModel updateDiaryModel);
    Task<BaseResponseModel> DeleteDiaryAsync(Guid id);
}
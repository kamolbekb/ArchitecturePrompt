using N_Tier.Application.Models;
using N_Tier.Application.Models.Info;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IInfoService
{
    Task<CreateInfoResponseModel> CreateInfoAsync(CreateInfoModel createInfoModel);
    Task<Info> GetInfoAsync(Guid id);
    Task<IEnumerable<InfoResponseModel>> GetAllInfoAsync();
    //Task<List<Info>> GetAllWithIQueryableAsync();
    //List<Info> GetAllWithIEnumerable();
    //Task<PagedResult<Info>> GetAllAsync(Options options);
    Task<PagedResult<InfoResponseModel>> GetAllAsync(Options options);
    Task<UpdateInfoResponseModel> UpdateInfoAsync(Guid id, UpdateInfoModel updateInfoModel);
    Task<BaseResponseModel> DeleteInfoAsync(Guid id);
}
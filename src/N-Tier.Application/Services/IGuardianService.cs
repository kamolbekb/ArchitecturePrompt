using N_Tier.Application.Models;
using N_Tier.Application.Models.Guardian;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IGuardianService
{
    Task<CreateGuardianResponseModel> CreateGuardianAsync(CreateGuardianModel createGuardianModel);
    Task<Guardian> GetGuardianAsync(Guid guardianId);
    Task<IEnumerable<GuardianResponseModel>> GetAllGuardiansAsync();
    //Task<List<Guardian>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Guardian>> GetAllAsync(Options options);
    Task<PagedResult<GuardianResponseModel>> GetAllGuardiansAsync(Options options);
    Task<UpdateGuardianResponseModel> UpdateGuardianAsync(Guid id, UpdateGuardianModel updateGuardianModel);
    Task<BaseResponseModel> DeleteGuardianAsync(Guid id);
}
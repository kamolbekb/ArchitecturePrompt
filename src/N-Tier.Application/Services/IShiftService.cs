using N_Tier.Application.Models;
using N_Tier.Application.Models.Shift;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IShiftService
{
    Task<CreateShiftResponseModel> CreateShiftAsync(CreateShiftModel createShiftModel);
    Task<Shift> GetShiftAsync(Guid shiftId);
    Task<IEnumerable<ShiftResponseModel>> GetAllShiftsAsync();
    //Task<List<Shift>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Shift>> GetAllAsync(Options options);
    Task<PagedResult<ShiftResponseModel>> GetAllShiftsAsync(Options options);
    Task<UpdateShiftResponseModel> UpdateShiftAsync(Guid id, UpdateShiftModel updateShiftModel);
    Task<BaseResponseModel> DeleteShiftAsync(Guid id);
}
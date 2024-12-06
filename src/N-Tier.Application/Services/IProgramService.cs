using N_Tier.Application.Models;
using N_Tier.Application.Models.Program;
using N_Tier.Core.Entities;

namespace N_Tier.Application.Services;

public interface IProgramService
{
    Task<CreateProgramResponseModel> CreateProgramAsync(CreateProgramModel createProgramModel);
    Task<Program> GetProgramAsync(Guid programId);
    Task<IEnumerable<ProgramResponseModel>> GetAllProgramsAsync();
    //Task<List<Program>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Program>> GetAllAsync(Options options);
    Task<PagedResult<ProgramResponseModel>> GetAllProgramsAsync(Options options);
    Task<UpdateProgramResponseModel> UpdateProgramAsync(Guid id, UpdateProgramModel updateProgramModel);
    Task<BaseResponseModel> DeleteProgramAsync(Guid id);
}
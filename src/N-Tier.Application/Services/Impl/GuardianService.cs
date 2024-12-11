using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Guardian;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class GuardianService : IGuardianService
{
    private readonly IMapper _mapper;
    private readonly IGuardianRepository _guardianRepository;

    public GuardianService(IMapper mapper, IGuardianRepository guardianRepository)
    {
        _mapper = mapper;
        _guardianRepository = guardianRepository;
    }

    public async Task<CreateGuardianResponseModel> CreateGuardianAsync(CreateGuardianModel createGuardianModel)
    {
        var guardian = _mapper.Map<Guardian>(createGuardianModel);
        var addedGuardian = await _guardianRepository.InsertAsync(guardian);
        return new CreateGuardianResponseModel
        {
            Id = addedGuardian.Id,
        };
    }
    
    public async Task<Guardian> GetGuardianAsync(Guid guardianId)
    {
        var storageGuardian = await _guardianRepository
            .SelectByIdAsync(guardianId);

        return await Task.FromResult(storageGuardian);
    }

    public async Task<IEnumerable<GuardianResponseModel>> GetAllGuardiansAsync()
    {
        var guardians = _guardianRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<GuardianResponseModel>>(guardians));
    }

    public Task<PagedResult<GuardianResponseModel>> GetAllGuardiansAsync(Options options)
    {
        object guardians = _guardianRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<GuardianResponseModel>>(_mapper.Map<PagedResult<GuardianResponseModel>>(guardians));
    }

    public async Task<UpdateGuardianResponseModel> UpdateGuardianAsync(Guid id, UpdateGuardianModel updateGuardianModel)
    {
        var guardian =  _guardianRepository.SelectAll()
            .FirstOrDefault(x => x.Id == id);
        _mapper.Map(updateGuardianModel, guardian);
        var updatedGuardian = await _guardianRepository.UpdateAsync(guardian);
        return new UpdateGuardianResponseModel()
        {
            Id = (await _guardianRepository.UpdateAsync(updatedGuardian)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteGuardianAsync(Guid id)
    {
        var guardian = _guardianRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _guardianRepository.DeleteAsync(guardian);
        await _guardianRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
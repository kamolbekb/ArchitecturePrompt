using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Shift;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class ShiftService : IShiftService
{
    private readonly IMapper _mapper;
    private readonly IShiftRepository _shiftRepository;

    public ShiftService(IMapper mapper, IShiftRepository shiftRepository)
    {
        _mapper = mapper;
        _shiftRepository = shiftRepository;
    }

    public async Task<CreateShiftResponseModel> CreateShiftAsync(CreateShiftModel createShiftModel)
    {
        var shift = _mapper.Map<Shift>(createShiftModel);
        var addedShift = await _shiftRepository.InsertAsync(shift);
        return new CreateShiftResponseModel
        {
            Id = addedShift.Id,
        };
    }
    
    public async Task<Shift> GetShiftAsync(Guid shiftId)
    {
        var storageShift = await _shiftRepository
            .SelectByIdAsync(shiftId);

        return await Task.FromResult(storageShift);
    }

    public async Task<IEnumerable<ShiftResponseModel>> GetAllShiftsAsync()
    {
        var shifts = _shiftRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<ShiftResponseModel>>(shifts));
    }

    public Task<PagedResult<ShiftResponseModel>> GetAllShiftsAsync(Options options)
    {
        object shifts = _shiftRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<ShiftResponseModel>>(_mapper.Map<PagedResult<ShiftResponseModel>>(shifts));
    }

    public async Task<UpdateShiftResponseModel> UpdateShiftAsync(Guid id, UpdateShiftModel updateShiftModel)
    {
        var shift =  _shiftRepository.SelectAll()
            .FirstOrDefault(x => x.Id == id);
        _mapper.Map(updateShiftModel, shift);
        var updatedShift = await _shiftRepository.UpdateAsync(shift);
        return new UpdateShiftResponseModel()
        {
            Id = (await _shiftRepository.UpdateAsync(updatedShift)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteShiftAsync(Guid id)
    {
        var shift = _shiftRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _shiftRepository.DeleteAsync(shift);
        await _shiftRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
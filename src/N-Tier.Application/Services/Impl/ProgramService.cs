using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Program;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class ProgramService : IProgramService
{
    private readonly IMapper _mapper;
    private readonly IProgramRepository _programRepository;

    public ProgramService(IMapper mapper, IProgramRepository programRepository)
    {
        _mapper = mapper;
        _programRepository = programRepository;
    }

    public async Task<CreateProgramResponseModel> CreateProgramAsync(CreateProgramModel createProgramModel)
    {
        var program = _mapper.Map<Program>(createProgramModel);
        var addedProgram = await _programRepository.InsertAsync(program);
        return new CreateProgramResponseModel
        {
            Id = addedProgram.Id,
        };
    }
    
    public async Task<Program> GetProgramAsync(Guid programId)
    {
        var storageProgram = await _programRepository
            .SelectByIdAsync(programId);

        return await Task.FromResult(storageProgram);
    }

    public async Task<IEnumerable<ProgramResponseModel>> GetAllProgramsAsync()
    {
        var programs = _programRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<ProgramResponseModel>>(programs));
    }

    public Task<PagedResult<ProgramResponseModel>> GetAllProgramsAsync(Options options)
    {
        object programs = _programRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<ProgramResponseModel>>(_mapper.Map<PagedResult<ProgramResponseModel>>(programs));
    }

    public async Task<UpdateProgramResponseModel> UpdateProgramAsync(Guid id, UpdateProgramModel updateProgramModel)
    {
        var program =  _programRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        program.Title = updateProgramModel.Title;
        program.Content = updateProgramModel.Content;
        program.Price = updateProgramModel.Price;
        return new UpdateProgramResponseModel()
        {
            Id = (await _programRepository.UpdateAsync(program)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteProgramAsync(Guid id)
    {
        var program = _programRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _programRepository.DeleteAsync(program);
        await _programRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
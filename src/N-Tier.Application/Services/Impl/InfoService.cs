using AutoMapper;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Info;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class InfoService : IInfoService
{
    private readonly IMapper _mapper;
    private readonly IInfoRepository _infoRepository;

    public InfoService(IMapper mapper, IInfoRepository infoRepository)
    {
        _mapper = mapper;
        _infoRepository = infoRepository;
    }

    public async Task<CreateInfoResponseModel> CreateInfoAsync(CreateInfoModel createInfoModel)
    {
        var info = _mapper.Map<Info>(createInfoModel);
        var addedInfo = await _infoRepository.InsertAsync(info);
        return new CreateInfoResponseModel
        {
            Id = addedInfo.Id,
        };
    }
    
    public async Task<Info> GetInfoAsync(Guid infoId)
    {
        var storageInfo = await _infoRepository
            .SelectByIdAsync(infoId);

        return await Task.FromResult(storageInfo);
    }

    public async Task<IEnumerable<InfoResponseModel>> GetAllInfoAsync()
    {
        var infos = _infoRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<InfoResponseModel>>(infos));
    }

    public Task<PagedResult<InfoResponseModel>> GetAllAsync(Options options)
    {
        object infos = _infoRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<InfoResponseModel>>(_mapper.Map<PagedResult<InfoResponseModel>>(infos));
    }

    public async Task<UpdateInfoResponseModel> UpdateInfoAsync(Guid id, UpdateInfoModel updateInfoModel)
    {
        var info =  _infoRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        info.Content = updateInfoModel.Content;
        info.CountOfStudents = updateInfoModel.CountOfStudents;
        info.CountOfTeachers = updateInfoModel.CountOfTeachers;
        return new UpdateInfoResponseModel()
        {
            Id = (await _infoRepository.UpdateAsync(info)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteInfoAsync(Guid id)
    {
        var info = _infoRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _infoRepository.DeleteAsync(info);
        await _infoRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
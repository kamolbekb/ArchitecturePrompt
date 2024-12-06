using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.DiaryRecord;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class DiaryRecordService : IDiaryRecordService
{
    private readonly IMapper _mapper;
    private readonly IDiaryRecordRepository _diaryRecordRepository;

    public DiaryRecordService(IMapper mapper, IDiaryRecordRepository diaryRecordRepository)
    {
        _mapper = mapper;
        _diaryRecordRepository = diaryRecordRepository;
    }

    public async Task<CreateDiaryRecordResponseModel> CreateDiaryRecordAsync(CreateDiaryRecordModel createDiaryRecordModel)
    {
        var diaryRecord = _mapper.Map<DiaryRecord>(createDiaryRecordModel);
        var addedDiaryRecord = await _diaryRecordRepository.InsertAsync(diaryRecord);
        return new CreateDiaryRecordResponseModel
        {
            Id = addedDiaryRecord.Id,
        };
    }
    
    public async Task<DiaryRecord> GetDiaryRecordAsync(Guid diaryRecordId)
    {
        var storageDiaryRecord = await _diaryRecordRepository
            .SelectByIdAsync(diaryRecordId);

        return await Task.FromResult(storageDiaryRecord);
    }

    public async Task<IEnumerable<DiaryRecordResponseModel>> GetAllDiaryRecordsAsync()
    {
        var diaryRecords = _diaryRecordRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<DiaryRecordResponseModel>>(diaryRecords));
    }

    public Task<PagedResult<DiaryRecordResponseModel>> GetAllDiaryRecordsAsync(Options options)
    {
        object diaryRecords = _diaryRecordRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<DiaryRecordResponseModel>>(_mapper.Map<PagedResult<DiaryRecordResponseModel>>(diaryRecords));
    }

    public async Task<UpdateDiaryRecordResponseModel> UpdateDiaryRecordAsync(Guid id, UpdateDiaryRecordModel updateDiaryRecordModel)
    {
        var diaryRecord =  _diaryRecordRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        diaryRecord.DiaryId = updateDiaryRecordModel.DiaryId;
        diaryRecord.Comment = updateDiaryRecordModel.Comment;
        diaryRecord.Score = updateDiaryRecordModel.Score;
        diaryRecord.Date = updateDiaryRecordModel.Date;
        diaryRecord.SubjectId = updateDiaryRecordModel.SubjectId;
        return new UpdateDiaryRecordResponseModel()
        {
            Id = (await _diaryRecordRepository.UpdateAsync(diaryRecord)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteDiaryRecordAsync(Guid id)
    {
        var diaryRecord = _diaryRecordRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _diaryRecordRepository.DeleteAsync(diaryRecord);
        await _diaryRecordRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
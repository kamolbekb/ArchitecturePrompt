using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Exam;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class ExamService : IExamService
{
    private readonly IMapper _mapper;
    private readonly IExamRepository _examRepository;

    public ExamService(IMapper mapper, IExamRepository examRepository)
    {
        _mapper = mapper;
        _examRepository = examRepository;
    }

    public async Task<CreateExamResponseModel> CreateExamAsync(CreateExamModel createExamModel)
    {
        var exam = _mapper.Map<Exam>(createExamModel);
        var addedExam = await _examRepository.InsertAsync(exam);
        return new CreateExamResponseModel
        {
            Id = addedExam.Id,
        };
    }
    
    public async Task<Exam> GetExamAsync(Guid examId)
    {
        var storageExam = await _examRepository
            .SelectByIdAsync(examId);

        return await Task.FromResult(storageExam);
    }

    public async Task<IEnumerable<ExamResponseModel>> GetAllExamsAsync()
    {
        var exams = _examRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<ExamResponseModel>>(exams));
    }

    public Task<PagedResult<ExamResponseModel>> GetAllExamsAsync(Options options)
    {
        object exams = _examRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<ExamResponseModel>>(_mapper.Map<PagedResult<ExamResponseModel>>(exams));
    }

    public async Task<UpdateExamResponseModel> UpdateExamAsync(Guid id, UpdateExamModel updateExamModel)
    {
        var exam =  _examRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        exam.GroupId = updateExamModel.GroupId;
        exam.RoomId = updateExamModel.RoomId;
        exam.SubjectId = updateExamModel.SubjectId;
        exam.StartTimeAt = updateExamModel.StartTimeAt;
        exam.EndTimeAt = updateExamModel.EndTimeAt;
        return new UpdateExamResponseModel()
        {
            Id = (await _examRepository.UpdateAsync(exam)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteExamAsync(Guid id)
    {
        var exam = _examRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _examRepository.DeleteAsync(exam);
        await _examRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
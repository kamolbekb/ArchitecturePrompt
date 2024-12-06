using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Subject;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class SubjectService : ISubjectService
{
    private readonly IMapper _mapper;
    private readonly ISubjectRepository _subjectRepository;

    public SubjectService(IMapper mapper, ISubjectRepository subjectRepository)
    {
        _mapper = mapper;
        _subjectRepository = subjectRepository;
    }

    public async Task<CreateSubjectResponseModel> CreateSubjectAsync(CreateSubjectModel createSubjectModel)
    {
        var subject = _mapper.Map<Subject>(createSubjectModel);
        var addedSubject = await _subjectRepository.InsertAsync(subject);
        return new CreateSubjectResponseModel
        {
            Id = addedSubject.Id,
        };
    }
    
    public async Task<Subject> GetSubjectAsync(Guid subjectId)
    {
        var storageSubject = await _subjectRepository
            .SelectByIdAsync(subjectId);

        return await Task.FromResult(storageSubject);
    }

    public async Task<IEnumerable<SubjectResponseModel>> GetAllSubjectsAsync()
    {
        var subjects = _subjectRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<SubjectResponseModel>>(subjects));
    }

    public Task<PagedResult<SubjectResponseModel>> GetAllSubjectsAsync(Options options)
    {
        object subjects = _subjectRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<SubjectResponseModel>>(_mapper.Map<PagedResult<SubjectResponseModel>>(subjects));
    }

    public async Task<UpdateSubjectResponseModel> UpdateSubjectAsync(Guid id, UpdateSubjectModel updateSubjectModel)
    {
        var subject =  _subjectRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        subject.Title = updateSubjectModel.Title;
        subject.Descriprion = updateSubjectModel.Descriprion;
        subject.TeacherId = updateSubjectModel.TeacherId;
        return new UpdateSubjectResponseModel()
        {
            Id = (await _subjectRepository.UpdateAsync(subject)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteSubjectAsync(Guid id)
    {
        var subject = _subjectRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _subjectRepository.DeleteAsync(subject);
        await _subjectRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
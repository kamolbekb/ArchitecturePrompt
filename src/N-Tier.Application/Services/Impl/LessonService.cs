using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Lesson;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class LessonService : ILessonService
{
    private readonly IMapper _mapper;
    private readonly ILessonRepository _lessonRepository;

    public LessonService(IMapper mapper, ILessonRepository lessonRepository)
    {
        _mapper = mapper;
        _lessonRepository = lessonRepository;
    }

    public async Task<CreateLessonResponseModel> CreateLessonAsync(CreateLessonModel createLessonModel)
    {
        var lesson = _mapper.Map<Lesson>(createLessonModel);
        var addedLesson = await _lessonRepository.InsertAsync(lesson);
        return new CreateLessonResponseModel
        {
            Id = addedLesson.Id,
        };
    }
    
    public async Task<Lesson> GetLessonAsync(Guid lessonId)
    {
        var storageLesson = await _lessonRepository
            .SelectByIdAsync(lessonId);

        return await Task.FromResult(storageLesson);
    }

    public async Task<IEnumerable<LessonResponseModel>> GetAllLessonsAsync()
    {
        var lessons = _lessonRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<LessonResponseModel>>(lessons));
    }

    public Task<PagedResult<LessonResponseModel>> GetAllLessonsAsync(Options options)
    {
        object lessons = _lessonRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<LessonResponseModel>>(_mapper.Map<PagedResult<LessonResponseModel>>(lessons));
    }

    public async Task<UpdateLessonResponseModel> UpdateLessonAsync(Guid id, UpdateLessonModel updateLessonModel)
    {
        var lesson =  _lessonRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        _mapper.Map(updateLessonModel, lesson);
        var updatedLesson = await _lessonRepository.UpdateAsync(lesson);
        return new UpdateLessonResponseModel()
        {
            Id = (await _lessonRepository.UpdateAsync(updatedLesson)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteLessonAsync(Guid id)
    {
        var lesson = _lessonRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _lessonRepository.DeleteAsync(lesson);
        await _lessonRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
using N_Tier.Application.Models;
using N_Tier.Application.Models.Lesson;
using N_Tier.Core.Entities;
namespace N_Tier.Application.Services;

public interface ILessonService
{
    Task<CreateLessonResponseModel> CreateLessonAsync(CreateLessonModel createLessonModel);
    Task<Lesson> GetLessonAsync(Guid lessonId);
    Task<IEnumerable<LessonResponseModel>> GetAllLessonsAsync();
    //Task<List<Lesson>> GetAllWithIQueryableAsync();
    //Task<PagedResult<Lesson>> GetAllAsync(Options options);
    Task<PagedResult<LessonResponseModel>> GetAllLessonsAsync(Options options);
    Task<UpdateLessonResponseModel> UpdateLessonAsync(Guid id, UpdateLessonModel updateLessonModel);
    Task<BaseResponseModel> DeleteLessonAsync(Guid id);
}
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Teacher;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class TeacherService : ITeacherService
{
    private readonly IMapper _mapper;
    private readonly ITeacherRepository _teacherRepository;

    public TeacherService(IMapper mapper, ITeacherRepository teacherRepository)
    {
        _mapper = mapper;
        _teacherRepository = teacherRepository;
    }

    public async Task<CreateTeacherResponseModel> CreateTeacherAsync(CreateTeacherModel createTeacherModel)
    {
        var teacher = _mapper.Map<Teacher>(createTeacherModel);
        var addedTeacher = await _teacherRepository.InsertAsync(teacher);
        return new CreateTeacherResponseModel
        {
            Id = addedTeacher.Id,
        };
    }
    
    public async Task<Teacher> GetTeacherAsync(Guid teacherId)
    {
        var storageTeacher = await _teacherRepository
            .SelectByIdAsync(teacherId);

        return await Task.FromResult(storageTeacher);
    }

    public async Task<IEnumerable<TeacherResponseModel>> GetAllTeachersAsync()
    {
        var teachers = _teacherRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<TeacherResponseModel>>(teachers));
    }

    public Task<PagedResult<TeacherResponseModel>> GetAllTeachersAsync(Options options)
    {
        object teachers = _teacherRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<TeacherResponseModel>>(_mapper.Map<PagedResult<TeacherResponseModel>>(teachers));
    }

    public async Task<UpdateTeacherResponseModel> UpdateTeacherAsync(Guid id, UpdateTeacherModel updateTeacherModel)
    {
        var teacher =  _teacherRepository.SelectAll().FirstOrDefault(x => x.Id == id);
        teacher.EmployeeId = updateTeacherModel.EmployeeId;
        teacher.SubjectId = updateTeacherModel.SubjectId;
        return new UpdateTeacherResponseModel()
        {
            Id = (await _teacherRepository.UpdateAsync(teacher)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteTeacherAsync(Guid id)
    {
        var teacher = _teacherRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _teacherRepository.DeleteAsync(teacher);
        await _teacherRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
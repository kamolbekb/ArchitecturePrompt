using AutoMapper;
using Microsoft.EntityFrameworkCore;
using N_Tier.Application.Extensions;
using N_Tier.Application.Models;
using N_Tier.Application.Models.Student;
using N_Tier.Core.Entities;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class StudentService : IStudentService
{
    private readonly IMapper _mapper;
    private readonly IStudentRepository _studentRepository;

    public StudentService(IMapper mapper, IStudentRepository studentRepository)
    {
        _mapper = mapper;
        _studentRepository = studentRepository;
    }

    public async Task<CreateStudentResponseModel> CreateStudentAsync(CreateStudentModel createStudentModel)
    {
        var student = _mapper.Map<Student>(createStudentModel);
        var addedStudent = await _studentRepository.InsertAsync(student);
        return new CreateStudentResponseModel
        {
            Id = addedStudent.Id,
        };
    }
    
    public async Task<Student> GetStudentAsync(Guid studentId)
    {
        var storageStudent = await _studentRepository
            .SelectByIdAsync(studentId);

        return await Task.FromResult(storageStudent);
    }

    public async Task<IEnumerable<StudentResponseModel>> GetAllStudentsAsync()
    {
        var students = _studentRepository
            .SelectAll();
        return await Task.FromResult(_mapper.Map<IEnumerable<StudentResponseModel>>(students));
    }

    public Task<PagedResult<StudentResponseModel>> GetAllStudentsAsync(Options options)
    {
        object students = _studentRepository
            .SelectAll()
            .ToPagedResultAsync(options);
        return Task.FromResult<PagedResult<StudentResponseModel>>(_mapper.Map<PagedResult<StudentResponseModel>>(students));
    }

    public async Task<UpdateStudentResponseModel> UpdateStudentAsync(Guid id, UpdateStudentModel updateStudentModel)
    {
        var student =  _studentRepository.SelectAll()
            .FirstOrDefault(x => x.Id == id);
        _mapper.Map(updateStudentModel, student);
        var updatedStudent = await _studentRepository.UpdateAsync(student);
        return new UpdateStudentResponseModel()
        {
            Id = (await _studentRepository.UpdateAsync(updatedStudent)).Id
        };
    }

    public async Task<BaseResponseModel> DeleteStudentAsync(Guid id)
    {
        var student = _studentRepository.SelectAll()
            .FirstOrDefault(d => d.Id == id);
        await _studentRepository.DeleteAsync(student);
        await _studentRepository.SaveChangesAsync();
        return new BaseResponseModel();

    }
}
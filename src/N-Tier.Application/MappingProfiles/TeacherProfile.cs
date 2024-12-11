using AutoMapper;
using N_Tier.Application.Models.Teacher;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class TeacherProfile : Profile
{
    public TeacherProfile()
    {
        CreateMap<CreateTeacherModel, Teacher>();
        CreateMap<UpdateTeacherModel, Teacher>();
        CreateMap<Teacher, TeacherResponseModel>();
    }
}

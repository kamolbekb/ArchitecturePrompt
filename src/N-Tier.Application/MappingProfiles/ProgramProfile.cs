using AutoMapper;
using N_Tier.Application.Models.Program;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class ProgramProfile : Profile
{
    public ProgramProfile()
    {
        CreateMap<CreateProgramModel, Program>();
        CreateMap<UpdateProgramModel, Program>();

        CreateMap<Program, ProgramResponseModel>();
    }
}
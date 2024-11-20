using AutoMapper;
using N_Tier.Application.Models.StudyProcess;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class StudyProcessProfile : Profile
{
    public StudyProcessProfile()
    {
        CreateMap<CreateStudyProcessModel, StudyProcess>();

        CreateMap<StudyProcess, StudyProcessResponseModel>();
    }
}

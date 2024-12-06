using AutoMapper;
using N_Tier.Application.Models.Guardian;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class GuardianProfile : Profile
{
    public GuardianProfile()
    {
        CreateMap<CreateGuardianModel, Guardian>();
        CreateMap<UpdateGuardianModel, Guardian>();

        CreateMap<Guardian, GuardianResponseModel>();
    }
}
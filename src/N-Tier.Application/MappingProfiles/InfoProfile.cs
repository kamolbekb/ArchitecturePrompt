using AutoMapper;
using N_Tier.Application.Models.Info;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class InfoProfile : Profile
{
    public InfoProfile()
    {
        CreateMap<CreateInfoModel, Info>();
        CreateMap<UpdateInfoModel, Info>();

        CreateMap<Info, InfoResponseModel>();
    }
}
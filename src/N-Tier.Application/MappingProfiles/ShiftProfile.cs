using AutoMapper;
using N_Tier.Application.Models.Shift;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class ShiftProfile : Profile
{
    public ShiftProfile()
    {
        CreateMap<CreateShiftModel, Shift>();
        CreateMap<UpdateShiftModel, Shift>();

        CreateMap<Shift, ShiftResponseModel>();
    }
}
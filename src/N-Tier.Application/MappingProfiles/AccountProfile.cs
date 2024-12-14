using AutoMapper;
using N_Tier.Application.Models.Auth;
using N_Tier.Core.Entities.User;

namespace N_Tier.Application.MappingProfiles;

public class AccountProfile : Profile
{
    public AccountProfile()
    {
        CreateMap<RegisterUserRequest,Account>();
    }
}
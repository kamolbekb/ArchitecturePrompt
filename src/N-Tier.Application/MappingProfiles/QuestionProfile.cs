using AutoMapper;
using N_Tier.Application.Models.Question;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class QuestionProfile : Profile
{
    public QuestionProfile()
    {
        CreateMap<CreateQuestionModel, Question>();
        CreateMap<UpdateQuestionModel, Question>();

        CreateMap<Question, QuestionResponseModel>();
    }
}
using AutoMapper;
using N_Tier.Application.Models.DiaryRecord;
using N_Tier.Core.Entities;

namespace N_Tier.Application.MappingProfiles;

public class DiaryRecordProfile : Profile
{
    public DiaryRecordProfile()
    {
        CreateMap<CreateDiaryRecordModel, DiaryRecord>();
        CreateMap<UpdateDiaryRecordModel, DiaryRecord>();

        CreateMap<DiaryRecord, DiaryRecordResponseModel>();
    }
}
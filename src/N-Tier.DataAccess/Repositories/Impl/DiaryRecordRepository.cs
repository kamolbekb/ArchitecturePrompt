using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;
namespace N_Tier.DataAccess.Repositories.Impl;
public class DiaryRecordRepository : BaseRepository<DiaryRecord, Guid>, IDiaryRecordRepository
{
    public DiaryRecordRepository(DatabaseContext context) : base(context) { }
}
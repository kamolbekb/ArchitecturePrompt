using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;

namespace N_Tier.DataAccess.Repositories.Impl;

public class StudyProcessRepository : BaseRepository<StudyProcess>, IStudyProcessRepository
{
    public StudyProcessRepository(DatabaseContext context) : base(context) { }
}
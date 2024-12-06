using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;
namespace N_Tier.DataAccess.Repositories.Impl;
public class ProgramRepository : BaseRepository<Program, Guid>, IProgramRepository
{
    public ProgramRepository(DatabaseContext context) : base(context) { }
}
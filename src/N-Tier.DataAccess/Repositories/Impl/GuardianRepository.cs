using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;
namespace N_Tier.DataAccess.Repositories.Impl;
public class GuardianRepository : BaseRepository<Guardian, Guid>, IGuardianRepository
{
    public GuardianRepository(DatabaseContext context) : base(context) { }
}
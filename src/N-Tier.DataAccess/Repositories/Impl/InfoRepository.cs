using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;
namespace N_Tier.DataAccess.Repositories.Impl;
public class InfoRepository : BaseRepository<Info, Guid>, IInfoRepository
{
    public InfoRepository(DatabaseContext context) : base(context) { }
}
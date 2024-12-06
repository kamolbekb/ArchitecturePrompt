using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;
namespace N_Tier.DataAccess.Repositories.Impl;

public class ShiftRepository : BaseRepository<Shift, Guid>, IShiftRepository
{
    public ShiftRepository(DatabaseContext context) : base(context) { }
}
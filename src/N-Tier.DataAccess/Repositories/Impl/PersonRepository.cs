using N_Tier.Core.Entities;
using N_Tier.DataAccess.Persistence;
namespace N_Tier.DataAccess.Repositories.Impl;
public class PersonRepository : BaseRepository<Person, Guid>, IPersonRepository
{
    public PersonRepository(DatabaseContext context) : base(context) { }
}
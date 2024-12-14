using N_Tier.Core.Entities.User;

namespace N_Tier.DataAccess.Repositories;

public interface IAccountRepository
{
    public void Add(Account account);

    public Account? GetByUserName(string userName);
}
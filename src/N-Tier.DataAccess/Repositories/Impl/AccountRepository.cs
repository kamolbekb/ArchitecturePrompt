using Microsoft.EntityFrameworkCore;
using N_Tier.Core.Entities.User;
using N_Tier.DataAccess.Persistence;

namespace N_Tier.DataAccess.Repositories.Impl;

public class AccountRepository : IAccountRepository
{
    //private static IDictionary<string,Account> Accounts = new Dictionary<string, Account>();
    private readonly DatabaseContext _appDbContext;

    public AccountRepository(DatabaseContext dbContext)=>
        _appDbContext = dbContext;

    public void Add(Account account)
    {
        //Accounts[account.UserName] = account;
        _appDbContext.Set<Account>().Add(account); // Добавляем запись в набор данных
        _appDbContext.SaveChanges();
    }
    
    public Account? GetByUserName(string userName)
    {
        //return Accounts.TryGetValue(userName, out var account) ? account : null;
        return _appDbContext.Set<Account>().FirstOrDefault(a => a.UserName == userName);
    }
}
using N_Tier.Core.Entities.User;

namespace N_Tier.Application.Services;

public interface IAccountService
{
    public void Register(string username,string firstname, string password,string role);
    public string Login(string username, string password);
}
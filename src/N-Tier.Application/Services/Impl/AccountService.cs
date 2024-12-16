using Microsoft.AspNetCore.Identity;
using N_Tier.Application.Helpers;
using N_Tier.Core.Entities.User;
using N_Tier.DataAccess.Repositories;

namespace N_Tier.Application.Services.Impl;

public class AccountService : IAccountService
{
    private readonly IAccountRepository _accountRepository;
    private readonly JwtHelper _jwtHelper;

    public AccountService(IAccountRepository accountRepository,JwtHelper jwtHelper)
    {
        _accountRepository = accountRepository;
        _jwtHelper = jwtHelper;
    }

    public void Register(string username, string firstname, string password, string role)
    {
        var newAccount = new Account
        {
            UserName = username,
            FirstName = firstname,
            Id = Guid.NewGuid(),
            Role = role // Assign the provided role
        };
        var passHash = new PasswordHasher<Account>().HashPassword(newAccount, password);
        newAccount.PasswordHash = passHash;
        _accountRepository.Add(newAccount);
    }


    public string Login(string username, string password)
    {
        var account = _accountRepository.GetByUserName(username);
        var result = new PasswordHasher<Account>()
            .VerifyHashedPassword(account, account.PasswordHash, password);
        if (result == PasswordVerificationResult.Success)
        {
            return _jwtHelper.GenerateToken(account); 
        }
        else
        {
            throw new Exception("Invalid username or password");
        }
    }
}
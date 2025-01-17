using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using N_Tier.Core.Entities.User;
using N_Tier.DataAccess.Identity;

namespace N_Tier.Application.Helpers;

public class JwtHelper
{
    private readonly IOptions<AuthSettings> options;

    public JwtHelper(IOptions<AuthSettings> options)
    {
        this.options = options;
    }
    public string  GenerateToken(Account account)
    {
        
        var claims = new List<Claim>
        {
            new Claim("userName", account.UserName),
            new Claim("firstName", account.FirstName),
            new Claim("id", account.Id.ToString()),
            new Claim(ClaimTypes.Role, account.Role.ToString()) // Add role to claims
        };

        var jwtToken = new JwtSecurityToken(
            expires: DateTime.UtcNow.Add(options.Value.Expires),
            claims: claims,
            signingCredentials:
            new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(options.Value.SecretKey)),
                SecurityAlgorithms.HmacSha256Signature)); 
        
        return new JwtSecurityTokenHandler().WriteToken(jwtToken);
    }
}

////var secretKey = configuration.GetValue<string>("JwtConfiguration:SecretKey");

////var key = Encoding.ASCII.GetBytes(secretKey);

////var tokenHandler = new JwtSecurityTokenHandler();

////var tokenDescriptor = new SecurityTokenDescriptor
////{
////    Subject = new ClaimsIdentity(new[]
////    {
////        new Claim(ClaimTypes.NameIdentifier, user.Id),
////        new Claim(ClaimTypes.Name, user.UserName),
////        new Claim(ClaimTypes.Email, user.Email)
////    }),
////    Expires = DateTime.UtcNow.AddDays(7),
////    SigningCredentials =
////        new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
////};

////var token = tokenHandler.CreateToken(tokenDescriptor);

////return tokenHandler.WriteToken(token);
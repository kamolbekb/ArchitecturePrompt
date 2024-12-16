using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

namespace N_Tier.Application.Helpers;

public static class AuthExtensions
{
    public static IServiceCollection AddAuth(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        var authSettings = configuration.GetSection(nameof(AuthSettings)).Get<AuthSettings>();

        serviceCollection.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(o =>
            {
                o.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(authSettings.SecretKey))
                };
            });

        serviceCollection.AddAuthorization(options =>
        {
            options.AddPolicy("SuperAdminOnly", policy =>
                policy.RequireClaim(ClaimTypes.Role, "SuperAdmin"));
        });
        // {
        //     options.AddPolicy("SuperAdminOnly", policy => policy.RequireRole("SuperAdmin"));
        // });

        return serviceCollection;
    }

}
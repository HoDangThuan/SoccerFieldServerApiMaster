using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

namespace SoccerFieldServer.api.App_Start
{
    public class JwtBearerConfig
    {
        public static void Config(JwtBearerOptions options)
        {
            options.RequireHttpsMetadata = false;
            options.SaveToken = true;
            options.TokenValidationParameters = new TokenValidationParameters
            {
                ClockSkew = TimeSpan.FromMinutes(Convert.ToInt32(Startup.Configuration["Jwt:expire_minutes"])),
                RequireExpirationTime = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = Startup.Configuration["Jwt:Issuer"],
                ValidAudience = Startup.Configuration["Jwt:Issuer"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Startup.Configuration["Jwt:Key"]))
            };
        }
    }
}

using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations
{
    public class TokenValidationConfiguration
    {
        private readonly IConfiguration _configuration;

        public TokenValidationConfiguration(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public TokenValidationParameters DefaultTokenConfiguration()
        {
            var jwtConfig = _configuration.GetSection("JwtConfig");
            var secretKey = jwtConfig["tokenSecret"];
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtConfig["validIssuer"],
                ValidAudience = jwtConfig["validAudience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ClockSkew = TimeSpan.Zero
            };

            return tokenValidationParameters;
        }

        public TokenValidationParameters DefaultRefreshTokenConfiguration()
        {
            var jwtConfig = _configuration.GetSection("JwtConfig");
            var secretKey = jwtConfig["refreshTokenSecret"];
            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwtConfig["validIssuer"],
                ValidAudience = jwtConfig["validAudience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey)),
                ClockSkew = TimeSpan.Zero
            };

            return tokenValidationParameters;
        }
    }
}

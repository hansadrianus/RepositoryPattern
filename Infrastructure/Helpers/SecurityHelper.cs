using AutoMapper.Configuration;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Helpers
{
    public class SecurityHelper
    {
        private readonly UserManager<ApplicationUser<string>> _userManager;
        private readonly IConfiguration _configuration;

        public SecurityHelper(UserManager<ApplicationUser<string>> userManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public SigningCredentials GetSigningCredentials()
        {
            var jwtConfig = _configuration.GetSection("AuthConfig");
            var key = Encoding.UTF8.GetBytes(jwtConfig["tokenSecret"]);
            var secret = new SymmetricSecurityKey(key);

            return new SigningCredentials(secret, SecurityAlgorithms.HmacSha256);
        }

        public async Task<List<Claim>> GetClaimsAsync(ApplicationUser<string> user, string lcid)
        {
            var selectedUser = await _userManager.FindByNameAsync(user.UserName);
            List<Claim> claims = new List<Claim>()
            {
                new Claim("Id", selectedUser.Id),
                new Claim(ClaimTypes.NameIdentifier, selectedUser.UserName),
                new Claim("Lcid", lcid)
            };

            var roles = await _userManager.GetRolesAsync(selectedUser);
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            return claims;
        }

        public JwtSecurityToken GenerateTokenOptions(SigningCredentials signingCredentials, List<Claim> claims)
        {
            var jwtConfig = _configuration.GetSection("AuthConfig");
            DateTime expireTime = DateTime.Now.AddMinutes(Convert.ToDouble(jwtConfig["tokenExpiresInMinutes"]));
            var tokenOptions = new JwtSecurityToken
            (
                issuer: jwtConfig["validIssuer"],
                audience: jwtConfig["validAudience"],
                claims: claims,
                notBefore: DateTime.Now,
                expires: expireTime,
                signingCredentials: signingCredentials
            );
            return tokenOptions;
        }

        public JwtSecurityToken GenerateRefreshToken(SigningCredentials signingCredentials)
        {
            var jwtConfig = _configuration.GetSection("AuthConfig");
            DateTime expireTime = DateTime.Now.AddMinutes(Convert.ToDouble(jwtConfig["refreshTokenExpiresInMinutes"]));
            var tokenOptions = new JwtSecurityToken
            (
                issuer: jwtConfig["validIssuer"],
                audience: jwtConfig["validAudience"],
                claims: null,
                notBefore: DateTime.Now,
                expires: expireTime,
                signingCredentials: signingCredentials
            );
            return tokenOptions;
        }
    }
}

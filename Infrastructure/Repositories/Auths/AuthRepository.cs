using Application.Endpoints.Auths.Commands;
using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.Auths;
using Application.ViewModels;
using Domain.Entities;
using Infrastructure.Helpers;
using Infrastructure.Persistence.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Infrastructure.Repositories.Auths
{
    public class AuthRepository : RepositoryBase<ApplicationUser>, IAuthRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;

        public AuthRepository(IApplicationContext context, UserManager<ApplicationUser> userManager, IConfiguration configuration) : base(context)
        {
            _userManager = userManager;
            _configuration = configuration;
        }

        public async Task<UserLoginViewModel> CreateTokenAsync(ApplicationUser user, string lcid, CancellationToken cancellationToken)
        {
            SecurityHelper securityHelper = new SecurityHelper(_userManager, _configuration);
            var signingCredentials = securityHelper.GetSigningCredentials();
            var claims = await securityHelper.GetClaimsAsync(user, lcid);
            var tokenOptions = securityHelper.GenerateTokenOptions(signingCredentials, claims);
            var refreshToken = securityHelper.GenerateRefreshToken(signingCredentials);

            var selectedUser = await _userManager.FindByNameAsync(user.UserName);
            selectedUser.Token = new JwtSecurityTokenHandler().WriteToken(tokenOptions);
            selectedUser.RefreshToken = new JwtSecurityTokenHandler().WriteToken(refreshToken);

            await _userManager.UpdateAsync(selectedUser);

            UserLoginViewModel model = new UserLoginViewModel()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(tokenOptions),
                RefreshToken = new JwtSecurityTokenHandler().WriteToken(refreshToken),
            };

            return model;
        }

        public async Task<RefreshTokenViewModel> RefreshTokenAsync(ApplicationUser user, string lcid, CancellationToken cancellationToken)
        {
            SecurityHelper securityHelper = new SecurityHelper(_userManager, _configuration);
            string accessToken = user.Token;
            string refreshToken = user.RefreshToken;
            if (ValidateRefreshToken(refreshToken) || string.IsNullOrEmpty(accessToken))
                return null;

            var currentUser = _userManager.Users.FirstOrDefault(q => q.Token == accessToken);
            if (currentUser == null)
                return null;

            var signingCredentials = securityHelper.GetSigningCredentials();
            var claims = await securityHelper.GetClaimsAsync(currentUser, lcid);
            var newAccessToken = securityHelper.GenerateTokenOptions(signingCredentials, claims);

            currentUser.Token = new JwtSecurityTokenHandler().WriteToken(newAccessToken);
            currentUser.RefreshToken = null;
            await _userManager.UpdateAsync(currentUser);

            RefreshTokenViewModel refreshTokenViewModel = new RefreshTokenViewModel()
            {
                AccessToken = currentUser.Token
            };

            return refreshTokenViewModel;
        }

        public async Task<ApplicationUser> RegisterUserAsync(ApplicationUser user, CancellationToken cancellationToken = default)
        {
            await _userManager.CreateAsync(user, user.PasswordHash);

            return user;
        }

        public async Task<bool> RemoveTokenAsync(Guid id, CancellationToken cancellationToken)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (user == null)
                return false;

            user.Token = null;
            user.RefreshToken = null;
            await _userManager.UpdateAsync(user);

            return true;
        }

        public async Task<bool> ValidateUserAsync(ApplicationUser user, CancellationToken cancellationToken)
        {
            var selectedUser = await _userManager.FindByNameAsync(user.UserName);

            return selectedUser != null && await _userManager.CheckPasswordAsync(selectedUser, user.PasswordHash);
        }

        private bool ValidateRefreshToken(string refreshToken)
        {
            try
            {
                TokenValidationParameters tokenValidation = new TokenValidationConfiguration(_configuration).DefaultRefreshTokenConfiguration();
                JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
                tokenHandler.ValidateToken(refreshToken, tokenValidation, out SecurityToken validatedToken);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

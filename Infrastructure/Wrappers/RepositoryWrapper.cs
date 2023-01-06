using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Wrappers;
using Domain.Entities;
using Infrastructure.Repositories.Auths;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Wrappers
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly IApplicationContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private IAuthRepository _auth;

        public RepositoryWrapper(IApplicationContext context, UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _configuration = configuration;
        }

        public IAuthRepository Auth
        {
            get
            {
                if (_auth == null)
                {
                    _auth = new AuthRepository(_context, _userManager, _configuration);
                }
                return _auth;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

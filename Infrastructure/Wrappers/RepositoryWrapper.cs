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
        private IRoleRepository _role;
        private IUserRoleRepository _userRole;

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
                _auth ??= new AuthRepository(_context, _userManager, _configuration);
                return _auth;
            }
        }

        public IRoleRepository Role
        {
            get
            {
                _role ??= new RoleRepository(_context);
                return _role;
            }
        }

        public IUserRoleRepository UserRoles
        {
            get
            {
                _userRole ??= new UserRoleRepository(_context);
                return _userRole;
            }
        }

        public void Save() => _context.SaveChanges();

        public async Task SaveAsync(CancellationToken cancellationToken) => await _context.SaveChangesAsync(cancellationToken);
    }
}

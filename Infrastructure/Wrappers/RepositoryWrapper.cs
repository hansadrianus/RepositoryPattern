using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.AppMenus;
using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Persistence.LanguageCultures;
using Application.Interfaces.Persistence.Products;
using Application.Interfaces.Persistence.SalesOrders;
using Application.Interfaces.Wrappers;
using Domain.Entities;
using Infrastructure.Repositories.AppMenus;
using Infrastructure.Repositories.Auths;
using Infrastructure.Repositories.LanguageCultures;
using Infrastructure.Repositories.Products;
using Infrastructure.Repositories.SalesOrders;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Wrappers
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly IApplicationContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private IAppMenuRepository _appMenu;
        private ILanguageCultureRepository _languageCulture;
        private IAuthRepository _auth;
        private IRoleRepository _role;
        private IUserRoleRepository _userRole;
        private IProductRepository _product;
        private ISalesOrderRepository _salesOrder;

        public RepositoryWrapper(IApplicationContext context, UserManager<ApplicationUser> userManager, IConfiguration configuration)
        {
            _context = context;
            _userManager = userManager;
            _configuration = configuration;
        }

        public IAppMenuRepository AppMenu
        {
            get
            {
                _appMenu ??= new AppMenuRepository(_context);
                return _appMenu;
            }
        }

        public ILanguageCultureRepository LanguageCulture
        {
            get
            {
                _languageCulture ??= new LanguageCultureRepository(_context);
                return _languageCulture;
            }
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

        public IProductRepository Product
        {
            get
            {
                _product ??= new ProductRepository(_context);
                return _product;
            }
        }

        public ISalesOrderRepository SalesOrder
        {
            get
            {
                _salesOrder ??= new SalesOrderRepository(_context);
                return _salesOrder;
            }
        }

        public void Save() => _context.SaveChanges();

        public async Task SaveAsync(CancellationToken cancellationToken) => await _context.SaveChangesAsync(cancellationToken);
    }
}

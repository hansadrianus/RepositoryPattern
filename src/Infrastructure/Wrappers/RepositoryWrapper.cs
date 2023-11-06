using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.AppMenus;
using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Persistence.LanguageCultures;
using Application.Interfaces.Persistence.OrderTypes;
using Application.Interfaces.Persistence.PaymentTypes;
using Application.Interfaces.Persistence.PhysicalInventoryDocuments;
using Application.Interfaces.Persistence.Products;
using Application.Interfaces.Persistence.SalesOrders;
using Application.Interfaces.Wrappers;
using Domain.Entities;
using Infrastructure.Repositories.AppMenus;
using Infrastructure.Repositories.Auths;
using Infrastructure.Repositories.LanguageCultures;
using Infrastructure.Repositories.OrderTypes;
using Infrastructure.Repositories.PaymentTypes;
using Infrastructure.Repositories.PhysicalInventoryDocuments;
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
        private IMenuRoleRepository _menuRole;
        private ILanguageCultureRepository _languageCulture;
        private IAuthRepository _auth;
        private IRoleRepository _role;
        private IUserRoleRepository _userRole;
        private IOrderTypeRepository _orderType;
        private IPaymentTypeRepository _paymentType;
        private IProductRepository _product;
        private ISalesOrderRepository _salesOrder;
        private IPhysicalInventoryDocumentRepository _physicalInventoryDocument;

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

        public IMenuRoleRepository MenuRole
        {
            get
            {
                _menuRole ??= new MenuRoleRepository(_context);
                return _menuRole;
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

        public IOrderTypeRepository OrderType
        {
            get
            {
                _orderType ??= new OrderTypeRepository(_context);
                return _orderType;
            }
        }

        public IPaymentTypeRepository PaymentType
        {
            get
            {
                _paymentType ??= new PaymentTypeRepository(_context);
                return _paymentType;
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

        public IPhysicalInventoryDocumentRepository PhysicalInventoryDocument
        {
            get
            {
                _physicalInventoryDocument ??= new PhysicalInventoryDocumentRepository(_context);
                return _physicalInventoryDocument;
            }
        }

        public void Save() => _context.SaveChanges();

        public async Task SaveAsync(CancellationToken cancellationToken) => await _context.SaveChangesAsync(cancellationToken);
    }
}

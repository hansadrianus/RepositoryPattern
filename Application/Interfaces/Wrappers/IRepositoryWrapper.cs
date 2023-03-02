using Application.Interfaces.Persistence.AppMenus;
using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Persistence.LanguageCultures;
using Application.Interfaces.Persistence.Products;
using Application.Interfaces.Persistence.SalesOrders;

namespace Application.Interfaces.Wrappers
{
    public interface IRepositoryWrapper
    {
        IAppMenuRepository AppMenu { get; }
        ILanguageCultureRepository LanguageCulture { get; }
        IAuthRepository Auth { get; }
        IRoleRepository Role { get; }
        IUserRoleRepository UserRoles { get; }
        IProductRepository Product { get; }
        ISalesOrderRepository SalesOrder { get; }

        void Save();
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Persistence.Products;
using Application.Interfaces.Persistence.SalesOrders;

namespace Application.Interfaces.Wrappers
{
    public interface IRepositoryWrapper
    {
        IAuthRepository Auth { get; }
        IProductRepository Product { get; }
        ISalesOrderRepository SalesOrder { get; }

        void Save();
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
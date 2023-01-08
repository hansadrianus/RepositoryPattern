using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Persistence.Products;

namespace Application.Interfaces.Wrappers
{
    public interface IRepositoryWrapper
    {
        IAuthRepository Auth { get; }
        IProductRepository Product { get; }

        void Save();
        Task SaveAsync();
    }
}
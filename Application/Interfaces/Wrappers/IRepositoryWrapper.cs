using Application.Interfaces.Persistence.Auths;

namespace Application.Interfaces.Wrappers
{
    public interface IRepositoryWrapper
    {
        IAuthRepository Auth { get; }

        void Save();
        Task SaveAsync();
    }
}
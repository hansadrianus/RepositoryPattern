using Application.Interfaces.Persistence.Auths;

namespace Application.Interfaces.Wrappers
{
    public interface IRepositoryWrapper
    {
        IAuthRepository Auth { get; }
        IRoleRepository Role { get; }
        IUserRoleRepository UserRoles { get; }

        void Save();
        Task SaveAsync(CancellationToken cancellationToken);
    }
}
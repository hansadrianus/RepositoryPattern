using Application.Endpoints.Auths.Commands;
using Application.ViewModels;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Persistence.Auths
{
    public interface IAuthRepository : IRepositoryBase<ApplicationUser>
    {
        Task<UserLoginViewModel> CreateTokenAsync(ApplicationUser user, string lcid, CancellationToken cancellationToken);
        Task<RefreshTokenViewModel> RefreshTokenAsync(ApplicationUser user, string lcid, CancellationToken cancellationToken);
        Task<ApplicationUser> RegisterUserAsync(ApplicationUser user, CancellationToken cancellationToken);
        Task<bool> RemoveTokenAsync(Guid id, CancellationToken cancellationToken);
        Task<bool> ValidateUserAsync(ApplicationUser user, CancellationToken cancellationToken);
    }
}

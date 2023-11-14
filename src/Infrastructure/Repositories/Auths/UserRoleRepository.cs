using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Services;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Auths
{
    public class UserRoleRepository : RepositoryBase<ApplicationUserRole>, IUserRoleRepository
    {
        public UserRoleRepository(IApplicationContext context, IDistributedCacheService distributedCacheService) : base(context, distributedCacheService)
        {
        }
    }
}

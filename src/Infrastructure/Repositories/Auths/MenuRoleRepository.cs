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
    public class MenuRoleRepository : RepositoryBase<AppMenuRole>, IMenuRoleRepository
    {
        public MenuRoleRepository(IApplicationContext context, IDistributedCacheService distributedCacheService) : base(context, distributedCacheService)
        {
        }
    }
}

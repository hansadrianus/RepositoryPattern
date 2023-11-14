using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.Auths;
using Application.Interfaces.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Auths
{
    public class RoleRepository : RepositoryBase<ApplicationRole>, IRoleRepository
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public RoleRepository(IApplicationContext context, IDistributedCacheService distributedCacheService, RoleManager<ApplicationRole> roleManager) : base(context, distributedCacheService)
        {
            _roleManager = roleManager;
        }

        public override async Task AddAsync(ApplicationRole entity, CancellationToken cancellationToken = default)
        {
            await _roleManager.CreateAsync(entity);
        }

        public override void Remove(ApplicationRole entity)
        {
            entity.RowStatus = 1;
            _roleManager.UpdateAsync(entity).ConfigureAwait(false);
        }

        public override void Update(ApplicationRole entity)
        {
            _roleManager.UpdateAsync(entity).ConfigureAwait(false);
        }
    }
}

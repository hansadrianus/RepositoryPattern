using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.Auths;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.Auths
{
    public class RoleRepository : RepositoryBase<ApplicationRole>, IRoleRepository
    {
        public RoleRepository(IApplicationContext context) : base(context)
        {
        }
    }
}

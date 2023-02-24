using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.AppMenus;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.AppMenus
{
    public class AppMenuRepository : RepositoryBase<AppMenu>, IAppMenuRepository
    {
        public AppMenuRepository(IApplicationContext context) : base(context)
        {
        }
    }
}

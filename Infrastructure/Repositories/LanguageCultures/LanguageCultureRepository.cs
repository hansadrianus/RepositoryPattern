using Application.Interfaces.Persistence;
using Application.Interfaces.Persistence.LanguageCultures;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.LanguageCultures
{
    public class LanguageCultureRepository : RepositoryBase<LanguageCulture>, ILanguageCultureRepository
    {
        public LanguageCultureRepository(IApplicationContext context) : base(context)
        {
        }
    }
}

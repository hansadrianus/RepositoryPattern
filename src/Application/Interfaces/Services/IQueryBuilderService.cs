using Application.Interfaces.Attributes;
using System.Linq.Expressions;

namespace Application.Interfaces.Services
{
    public interface IQueryBuilderService
    {
        Expression<Func<TDbType, bool>> BuildPredicate<TDbType, TSearchCriteria>(TSearchCriteria searchCriteria);
    }
}
namespace Application.Interfaces.Services
{
    public interface IEntityMapperService
    {
        TEntity MapValues<TEntity>(TEntity sourceEntity, TEntity targetEntity);
    }
}
namespace Domain.Common
{
    public interface IUidAuditableEntity
    {
        Guid Uid { get; set; }
    }
}
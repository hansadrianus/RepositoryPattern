using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class LanguageCulture<TKey> : AuditableEntity<TKey> where TKey : IEquatable<TKey>
    {
        public int LCID { get; set; }
        public string Description { get; set; }
        public bool IsDefaultLanguage { get; set; }
    }
}

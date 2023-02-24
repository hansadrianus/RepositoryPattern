using Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class LanguageCulture : AuditableEntity
    {
        public int LCID { get; set; }
        public string Description { get; set; }
        public bool IsDefaultLanguage { get; set; }
    }
}

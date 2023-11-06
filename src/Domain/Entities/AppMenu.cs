using Domain.Common;

namespace Domain.Entities
{
    public class AppMenu : AuditableEntity 
    {
        public string MenuName { get; set; }
        public string MenuController { get; set; }
        public string MenuAction { get; set; }
        public int MenuParent { get; set; }
        public int MenuLevel { get; set; }
        public int MenuOrder { get; set; }
        public string CssClass { get; set; }

        public virtual ICollection<AppMenuRole> MenuRoles { get; set; }
    }
}

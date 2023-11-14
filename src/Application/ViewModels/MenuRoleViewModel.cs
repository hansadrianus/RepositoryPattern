using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record MenuRoleViewModel
    {
        public Guid Uid { get; set; }
        public Guid AppMenuId { get; set; }
        public Guid RoleId { get; set; }
        public string MenuName { get; set; }
        public bool IsSelected { get; set; }
    }
}

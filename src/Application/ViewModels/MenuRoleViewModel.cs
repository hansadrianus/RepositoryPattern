using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record MenuRoleViewModel
    {
        public int Id { get; set; }
        public int AppMenuId { get; set; }
        public int RoleId { get; set; }
        public string MenuName { get; set; }
        public bool IsSelected { get; set; }
    }
}

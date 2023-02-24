using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AppMenuRole : AuditableEntity
    {
        public string RoleId { get; set; }
        public int AppMenuId { get; set; }

        [ForeignKey("RoleId")]
        public ApplicationRole Role { get; set; }
        [ForeignKey("AppMenuId")]
        public AppMenu Menu { get; set; }
    }
}

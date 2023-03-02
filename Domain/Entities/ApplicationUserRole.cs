using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationUserRole : AuditableUserRoleEntity
    {
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        [ForeignKey("RoleId")]
        public virtual ApplicationRole Role { get; set; }
    }
}

using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationRole : AuditableRoleEntity
    {
        public virtual ICollection<ApplicationUserRole>? UserRoles { get; set; }
        public virtual ICollection<IdentityRoleClaim<string>>? RoleClaims { get; set; }
        public virtual ICollection<AppMenuRole>? MenuRoles { get; set; }
    }
}

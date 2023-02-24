using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationRole<TKey> : AuditableRoleEntity<TKey> where TKey : IEquatable<TKey>
    {
        public virtual ICollection<ApplicationUserRole<TKey>>? UserRoles { get; set; }
        public virtual ICollection<IdentityRoleClaim<TKey>>? RoleClaims { get; set; }
        public virtual ICollection<AppMenuRole<TKey>>? MenuRoles { get; set; }
    }
}

using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationUserRole<TKey> : AuditableUserRoleEntity<TKey> where TKey : IEquatable<TKey>
    {
        [ForeignKey("UserId")]
        public ApplicationUser<TKey> User { get; set; }
        [ForeignKey("RoleId")]
        public ApplicationRole<TKey> Role { get; set; }
    }
}

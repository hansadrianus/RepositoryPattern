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
    public class AppMenuRole<TKey> : AuditableEntity<TKey> where TKey : IEquatable<TKey>
    {
        public TKey RoleId { get; set; }
        public TKey AppMenuId { get; set; }

        [ForeignKey("RoleId")]
        public ApplicationRole<TKey> Role { get; set; }
        [ForeignKey("AppMenuId")]
        public AppMenu<TKey> Menu { get; set; }
    }
}

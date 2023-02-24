using Domain.Common;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationUser<TKey> : AuditableIdentityEntity<TKey> where TKey : IEquatable<TKey>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public byte[]? ProfilePicture { get; set; }

        public virtual ICollection<ApplicationUserRole<TKey>>? UserRoles { get; set; }
        public virtual ICollection<IdentityUserClaim<TKey>>? UserClaims { get; set; }
        public virtual ICollection<IdentityUserLogin<TKey>>? UserLogins { get; set; }
        public virtual ICollection<IdentityUserToken<TKey>>? UserTokens { get; set; }
    }
}

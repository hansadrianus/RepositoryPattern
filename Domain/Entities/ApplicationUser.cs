using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class ApplicationUser : AuditableIdentityEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? Token { get; set; }
        public string? RefreshToken { get; set; }
        public byte[]? ProfilePicture { get; set; }
    }
}

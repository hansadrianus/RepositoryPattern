using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract class AuditableUserLoginEntity : IdentityUserLogin<int>, IAuditableEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Uid { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedTime { get; set; }
        [Timestamp, ConcurrencyCheck]
        public byte[] RowVersion { get; set; }
        public short RowStatus { get; set; }
    }
}

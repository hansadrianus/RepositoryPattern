using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public interface IAuditableEntity
    {
        string CreatedBy { get; set; }
        DateTime CreatedTime { get; set; }
        string? ModifiedBy { get; set; }
        DateTime? ModifiedTime { get; set; }
        byte[] RowVersion { get; set; }
        short RowStatus { get; set; }
    }
}

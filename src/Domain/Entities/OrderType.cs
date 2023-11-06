using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class OrderType : AuditableEntity
    {
        public string Name { get; set; }

        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}

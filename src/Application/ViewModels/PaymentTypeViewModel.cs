using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record PaymentTypeViewModel
    {
        public Guid Uid { get; set; }
        public string Name { get; set; }
        public short RowStatus { get; set; }
    }
}

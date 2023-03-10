using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record ProductViewModel
    {
        public int? Id { get; set; }
        public string ProductCode { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Type { get; set; }
    }
}

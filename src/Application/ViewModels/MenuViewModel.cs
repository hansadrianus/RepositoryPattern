using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record MenuViewModel
    {
        public Guid Uid { get; set; }
        public string MenuName { get; set; }
        public string MenuController { get; set; }
        public string MenuAction { get; set; }
        public int MenuParent { get; set; }
        public int MenuLevel { get; set; }
        public int MenuOrder { get; set; }
        public string CssClass { get; set; }
        public short RowStatus { get; set; }
    }
}

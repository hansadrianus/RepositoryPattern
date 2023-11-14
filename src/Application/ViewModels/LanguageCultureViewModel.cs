using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record LanguageCultureViewModel
    {
        public Guid Uid { get; set; }
        public int LCID { get; set; }
        public string Description { get; set; }
        public bool IsDefaultLanguage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record RefreshTokenViewModel
    {
        public string AccessToken { get; set; }
    }
}

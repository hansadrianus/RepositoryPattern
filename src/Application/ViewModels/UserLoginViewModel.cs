using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ViewModels
{
    public record UserLoginViewModel
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}

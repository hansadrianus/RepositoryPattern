using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Enumerations
{
    public enum EndpointResultStatus
    {
        Success = 0,
        BadRequest = 1,
        NotFound = 2,
        Invalid = 3,
        Duplicate = 4,
        Unauthorized = 5,
        Gone = 6,
        Error = -1
    }
}

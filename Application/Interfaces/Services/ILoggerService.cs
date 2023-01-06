using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Services
{
    public interface ILoggerService<TCategoryName>
    {
        void LogInformation(string message);
        void LogError(Exception exception);
        void LogError(Exception exception, string message);
    }
}

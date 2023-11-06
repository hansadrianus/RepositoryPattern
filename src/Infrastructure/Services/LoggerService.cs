using Application.Interfaces.Services;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    [ExcludeFromCodeCoverage]
    public class LoggerService<TCategoryName> : ILoggerService<TCategoryName>
    {
        private readonly ILogger<TCategoryName> _logger;

        public LoggerService(ILogger<TCategoryName> logger)
        {
            _logger = logger;
        }

        public void LogError(Exception exception)
        {
            _logger.LogError(exception, exception.Message);
        }

        public void LogError(Exception exception, string message)
        {
            _logger.LogError(exception, message);
        }

        public void LogInformation(string message)
        {
            _logger.LogInformation(message);
        }
    }
}

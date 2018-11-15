using Car4U.Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Car4U.Infrastructure.Logging
{
    public class LoggerAdapter<T> : IAppLogger<T>
    {
        private readonly ILogger<T> _logger;
        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<T>();
        }

        public void LogError(string msg, params object[] args)
        {
            _logger.LogError(msg, args);
        }

        public void LogInfo(string msg, params object[] args)
        {
            _logger.LogError(msg, args);

        }
    }
}

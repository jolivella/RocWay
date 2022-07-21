using Microsoft.Extensions.Logging;
using RocWay.Transversal.Common;

namespace RocWay.Transversal.Loggin
{
    public class LoggerAdapter<T> : IAppLogger<T>
    {
        private readonly ILogger<T> logger;
        public LoggerAdapter(ILoggerFactory loggerFactory)
        {
            logger = loggerFactory.CreateLogger<T>();
        }
        public void LogInformation(string message, params object[] args)
        {
            logger.LogInformation(message, args);
        }

        public void LogWarning(string message, params object[] args)
        {
            logger.LogWarning(message, args);
        }

        public void LogError(string message, params object[] args)
        {
            logger.LogError(message, args);
        }
    }
}

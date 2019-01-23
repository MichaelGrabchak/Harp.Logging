using Harp.Dependencies;

namespace Harp.Logging.Loggers
{
    public static class LogManager
    {
        private static readonly ILoggerProvider LoggerProvider;

        static LogManager()
        {
            LoggerProvider = Container.Resolve<ILoggerProvider>();
        }

        public static ILogger GetLogger()
        {
            return LoggerProvider.GetLogger();
        }

        public static ILogger GetLogger(string logName)
        {
            return LoggerProvider.GetLogger(logName);
        }
    }
}

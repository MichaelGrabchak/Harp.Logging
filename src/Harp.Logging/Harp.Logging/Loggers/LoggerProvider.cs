using System.Collections.Generic;

using Harp.Dependencies;

namespace Harp.Logging.Loggers
{
    public class LoggerProvider : ILoggerProvider
    {
        private const string LogNameParamKey = "logName";

        public virtual ILogger GetLogger()
        {
            return ResolveLogger();
        }

        public virtual ILogger GetLogger(string logName)
        {
            return ResolveLogger(logName);
        }

        #region Helpers

        private ILogger ResolveLogger()
        {
            return Container.Resolve<ILogger>();
        }

        private ILogger ResolveLogger(string logName)
        {
            if (string.IsNullOrEmpty(logName))
            {
                return ResolveLogger();
            }

            return Container.Resolve<ILogger>(new KeyValuePair<string, object>(LogNameParamKey, logName));
        }

        #endregion
    }
}

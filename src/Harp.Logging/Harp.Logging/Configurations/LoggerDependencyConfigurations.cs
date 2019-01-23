using Harp.Dependencies;
using Harp.Dependencies.Configurations;
using Harp.Logging.Loggers;

namespace Harp.Logging.Configurations
{
    public class LoggerDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            RegisterLogger();
            RegisterProvider();
        }

        protected virtual void RegisterLogger()
        {
            Container.RegisterType<ILogger, NoLogger>(Constants.LoggerNames.DefaultLogger);
        }

        protected virtual void RegisterProvider()
        {
            Container.RegisterType<ILoggerProvider, LoggerProvider>();
        }
    }
}

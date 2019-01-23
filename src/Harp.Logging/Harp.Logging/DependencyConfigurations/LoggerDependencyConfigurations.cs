using Harp.Dependencies;
using Harp.Dependencies.Configurations;
using Harp.Logging.Loggers;

namespace Harp.Logging.DependencyConfigurations
{
    public class LoggerDependencyConfigurations : IDependencyConfiguration
    {
        public void Configure()
        {
            this.RegisterLogger();
            this.RegisterProvider();
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

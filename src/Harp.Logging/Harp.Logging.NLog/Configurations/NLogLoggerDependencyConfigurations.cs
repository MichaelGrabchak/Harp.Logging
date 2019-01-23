using Harp.Dependencies;
using Harp.Logging.Configurations;
using Harp.Logging.NLog.Loggers;

namespace Harp.Logging.NLog.Configurations
{
    public sealed class NLogLoggerDependencyConfigurations : LoggerDependencyConfigurations
    {
        protected override void RegisterLogger()
        {
            Container.RegisterType<ILogger, NLogLogger>(Constants.LoggerNames.DefaultLogger);
        }
    }
}

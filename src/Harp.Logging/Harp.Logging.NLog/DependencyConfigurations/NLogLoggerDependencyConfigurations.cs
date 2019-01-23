using Harp.Dependencies;
using Harp.Logging.NLog.Loggers;

namespace Harp.Logging.NLog.DependencyConfigurations
{
    using Harp.Logging.DependencyConfigurations;

    public sealed class NLogLoggerDependencyConfigurations : LoggerDependencyConfigurations
    {
        protected override void RegisterLogger()
        {
            Container.RegisterType<ILogger, NLogLogger>(Constants.LoggerNames.DefaultLogger);
        }
    }
}

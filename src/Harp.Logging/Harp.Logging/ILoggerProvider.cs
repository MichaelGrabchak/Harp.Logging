namespace Harp.Logging
{
    public interface ILoggerProvider
    {
        ILogger GetLogger();
        ILogger GetLogger(string logName);
    }
}

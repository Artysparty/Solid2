using Solid2.Appenders;

namespace Solid2.Logger;

public class Logger : ILogger
{
    IAppender _appender;
    IAppender _appender1;
    public Logger(IAppender appender, IAppender? appender1 = null)
    {
        _appender = appender;
        _appender1 = appender1;
    }

    public void Error(string time, string message)
    {
        _appender.Write($"time: {time}  ", $"error: {message}");
        if (_appender1 != null)
            _appender1.Write($"time: {time}  ", $"error: {message}");
    }

    public void Info(string time, string message)
    {
        _appender.Write($"time: {time}  ", $"info: {message}");
        if (_appender1 != null)
            _appender1.Write($"time: {time}  ", $"info: {message}");
    }
}
using Solid2.Layout;

namespace Solid2.Appenders;

public class FileAppender : IAppender
{
    private readonly ILayout _layout;
    private readonly ILogFile _logFile;
    public FileAppender(ILayout layout, ILogFile logFile)
    {
        _layout = layout;
        _logFile = logFile;
    }

    public void Write(string time, string message)
    {
        _logFile.SetData(_layout.GetLayout(time, message));
    }
}
using Solid2.Layout;

namespace Solid2.Appenders;

public class ConsoleAppender : IAppender
{
    private readonly ILayout _layout;
    public ConsoleAppender(ILayout layout)
    {
        _layout = layout;
    }

    public void Write(string time, string message)
    {
        Console.WriteLine(_layout.GetLayout(time, message));
    } 
}
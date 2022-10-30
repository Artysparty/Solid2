namespace Solid2.Layout;

public class SimpleLayout : ILayout
{
    public string GetLayout(string time, string message)
    {
        return time+message;
    }
}
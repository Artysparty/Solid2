namespace Solid2.Appenders;

public interface IAppender
{
    public void Write(string time, string message);
}
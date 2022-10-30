namespace Solid2.Logger;

public interface ILogger
{
    public void Error(string time, string message);
    public void Info(string time, string message);
}
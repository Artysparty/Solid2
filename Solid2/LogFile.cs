namespace Solid2;

public class LogFile : ILogFile
{
    private List<string> _data;
    public LogFile()
    {
        _data = new List<string>();
    }
    public void SetData(string log)
    {
        _data.Add(log);
    }
}
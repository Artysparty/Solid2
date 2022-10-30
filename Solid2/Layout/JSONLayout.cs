using Newtonsoft.Json;

namespace Solid2.Layout;

public class JSONLayout : ILayout
{
    public string GetLayout(string time, string message)
    {
        string json = JsonConvert.SerializeObject(new { time = time, message = message });
        return json;
    }
}
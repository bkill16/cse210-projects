using System.Dynamic;

public class Assignment
{
    private string _name;
    private string _topic;

    public Assignment(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetTopic()
    {
        return _topic;
    }

    public void GetSummary()
    {
        Console.WriteLine($"{_name} - {_topic}");
    }
}
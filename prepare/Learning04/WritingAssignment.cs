public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetStudentName()
    {
        return GetName();
    }

    public void GetWritingInformation()
    {
        Console.WriteLine($"{_title} by {GetStudentName()}");
    }
}
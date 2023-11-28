using System.Runtime.CompilerServices;

public class Lecture : Event {
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($" Event Type: {GetEventType(this)}");
        Console.WriteLine($" Speaker: {_speaker}");
        Console.WriteLine($" Capacity: {_capacity}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($" Event Type: {GetEventType(this)}");
        TitleAndDate();
    }
}
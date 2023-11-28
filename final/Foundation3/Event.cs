public class Event {
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void StandardDetails()
    {
        Console.WriteLine($" {_title} - {_description}");
        Console.WriteLine($" {_date}, {_time}");
        _address.FormatAddress();
    }

    public string GetEventType(object obj)
    {
        Type type = obj.GetType();
        return type.Name;
    }

    public void TitleAndDate()
    {
        Console.WriteLine($" {_title}");
        Console.WriteLine($" {_date}");
    }
}
public class Outdoor : Event {
    private string _weather;

    public Outdoor(string title, string description, string date, string time, Address address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($" Event Type: {GetEventType(this)}");
        Console.WriteLine($" Weather Forecast: {_weather}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($" Event Type: {GetEventType(this)}");
        TitleAndDate();
    }
}
public class Reception : Event {
    private string _email;

    public Reception(string title, string description, string date, string time, Address address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public void FullDetails()
    {
        StandardDetails();
        Console.WriteLine($" Event Type: {GetEventType(this)}");
        Console.WriteLine($" RSVP Email: {_email}");
    }

    public void ShortDescription()
    {
        Console.WriteLine($" Event Type: {GetEventType(this)}");
        TitleAndDate();
    }
}
public class SmartHeater : SmartDevice {
    private int _currentTemp;

    public SmartHeater(string _name) : base(_name)
    {
        
    }

    public void ChangeTemp()
    {
        Console.WriteLine("Enter temp: ");
        string userInput = Console.ReadLine();
        _currentTemp = int.Parse(userInput);
        Console.WriteLine($"Temperature changed to {_currentTemp}");
    }

    public int GetCurrentTemp()
    {
        return _currentTemp;
    }

    public void DisplayTemp()
    {
        Console.WriteLine($"Current Temperature: {_currentTemp}");
    }
}
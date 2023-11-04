public class Activity {
    private string _name;
    private string _description;
    protected int _duration;
    protected TimeSpan _countdown;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Get activity name
    public string GetName()
    {
        return _name;
    }

    // Get activity description
    public string GetDescription()
    {
        return _description;
    }

    // Form and display the start message
    public void StartMsg()
    {
        Console.WriteLine($"Welcome to the {_name} Mindfulness Activity.");
        Console.WriteLine($"{_description}");
    }

    // Get the activity duration
    public void GetDuration()
    {
        Console.WriteLine($"\nFor how many seconds would you like to perform the {_name} activity? ");

        while (!int.TryParse(Console.ReadLine(), out _duration))
        {
            Console.WriteLine("Invalid input. Please enter a number of seconds.");
        }
    }

    // Display a countdown from 5 before the activity starts
    public void ReadyToBegin()
    {
        Console.WriteLine("\nBeginning activity in...");
        for (int i = 5; i > 0; i--)
            {
                Console.Write($"\b\b\b{i}");
                Thread.Sleep(1000);
            }
        
        Console.Clear();
    }

    // Create a spinner
    public void PauseSpinner(int duration)
    {
        Console.CursorVisible = false;
        string [] spinnerChar = {"-", "\\", "|", "/"};
        int index = 0;
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.Write($"\b{spinnerChar[index]}");
            Thread.Sleep(100);
            index = (index + 1) % spinnerChar.Length;
        }
        Console.Write("\b \b");
        Console.CursorVisible = true;
    }

    // Form and display the end message
    public void EndMsg()
    {
        Console.WriteLine($"\nGood job! You completed the {_name} Activity for {_duration} seconds.");
    }

    // Convert duration into a timespan
    public TimeSpan GetCountdown()
    {
        TimeSpan _countdown = TimeSpan.FromSeconds(_duration);
        return _countdown;
    }

    // Run through the activity, with PeformActivity() being specific to each individual activity
    public void RunActivity(ref bool displayMenu, Action PerformActivity)
    {
        Console.Clear();
        displayMenu = false;
        StartMsg();
        GetDuration();
        ReadyToBegin();
        PerformActivity();
        EndMsg();
        Thread.Sleep(5000);
        Console.Clear();
        displayMenu = true;
    }
}
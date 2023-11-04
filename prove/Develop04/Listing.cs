using System.Diagnostics;

public class Listing : Activity {
    private string _liPrompt;

    public Listing(string name, string description) : base(name, description)
    {

    }

    // Array of list prompts
    public static string[] _listPrompt = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    // Creation of lists, one empty to add user inputs to
    public List<string> lprompt = new List<string>(_listPrompt);
    public List<string> items = new List<string>();
    
    // Creation of stopwatch
    private static Stopwatch stopwatch = new Stopwatch();

    // Random selection of prompt
    public string RandomListPrompt()
    {
        var random = new Random();
        int index = random.Next(lprompt.Count());
        string _liPrompt = lprompt[index];
        return _liPrompt;
    }

    // Display the prompt
    public void DisplayListPrompt()
    {
        _liPrompt = RandomListPrompt();
        Console.WriteLine(_liPrompt);
    }

    // User inputs items until timer runs out and they're added to the items list
    public void ListItems()
    {
        _countdown = GetCountdown();
        stopwatch.Restart();
        items.Clear();
        stopwatch.Start();
        while (stopwatch.Elapsed < _countdown)
        {
            Console.Write("> ");
            string userInput = Console.ReadLine();
            items.Add(userInput);
        }
        stopwatch.Stop();
    }

    // The number of items the user listed are displayed
    public void DisplayListItems()
    {
        int itemCount = items.Count();
        Console.WriteLine($"You entered {itemCount} items.");
    }

    // Set PerformActivity for this class
    public void PerformActivity()
    {
        DisplayListPrompt();
        ListItems();
        DisplayListItems();
    }
}
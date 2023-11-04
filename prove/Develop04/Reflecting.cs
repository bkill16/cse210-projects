using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Reflecting : Activity {
    private string _thePrompt;

    public Reflecting(string name, string description) : base(name, description)
    {
        
    }

    // Array of main prompts
    public static string[] _refPrompt = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
    };

    // Array of questions about the main prompt
    public static string[] _refQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    // Creation of lists from arrays and new list for storing used questions
    public List<string> rprompt = new List<string>(_refPrompt);
    public List<string> rquestions = new List<string>(_refQuestions);
    public List<int> usedQuestions = new List<int>();
    
    // Creation of stopwatch
    private static Stopwatch stopwatch = new Stopwatch();

    // Random selection of main prompt
    public string RandomRefPrompt()
    {
        var random = new Random();
        int index = random.Next(rprompt.Count());
        string _thePrompt = rprompt[index];
        return _thePrompt;
    }

    // Random selection of questions without selecting the same one twice (unless all have already been
    // selected)
    public string RandomRefQuestion()
    {
        if (usedQuestions.Count == rquestions.Count())
        {
            usedQuestions.Clear();
        }

        int index;
        do {
            var random = new Random();
            index = random.Next(rquestions.Count());
        } while (usedQuestions.Contains(index));

        usedQuestions.Add(index);
        return rquestions[index];
    }

    // Display the main prompt with a 3 second loading spinner
    public void DisplayMainPrompt()
    {
        _thePrompt = RandomRefPrompt();
        Console.WriteLine($"{_thePrompt}");
        PauseSpinner(3);
    }

    // Display questions about the main prompt with a 5 second loading spinner between
    public void DisplayPromptQuestions()
    {
        _countdown = GetCountdown();
        stopwatch.Restart();
        stopwatch.Start();
        while (stopwatch.Elapsed < _countdown)
        {
            string randomQuestion = RandomRefQuestion();
            Console.WriteLine($"\n{randomQuestion}");
            PauseSpinner(5);
        }
    }

    // Set PerformActivity for this class
    public void PerformActivity()
    {
        DisplayMainPrompt();
        DisplayPromptQuestions();
    }
}
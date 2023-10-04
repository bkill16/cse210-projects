public class Prompt{

    public static string[] _prompt = {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
    };

    public List<string> _writingPrompt = new List<string>(_prompt);

    public string GeneratePrompt()
    {
        var random = new Random();
        int index = random.Next(_writingPrompt.Count);
        string writingPrompt = _writingPrompt[index];
        
        return writingPrompt;
    }
}
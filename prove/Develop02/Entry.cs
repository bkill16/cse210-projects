using System;

public class Entry
{
    public string _currentDate = "";
    public string _writingPrompt = "";
    public string _journalEntry = "";

    public void Display()
    {
        Console.WriteLine($"\n{_currentDate}");
        Console.WriteLine(_writingPrompt);
        Console.WriteLine($"{_journalEntry}");
    }
}
using System;
using System.IO;
using System.Text;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    private string _fileName;

    public Journal()
    {}

    public void Display()
    {
        Console.WriteLine("\nEntries:");
        foreach (Entry entry in _journal)
        {
            entry.Display();
        }
    }

    public void CreateFile()
    {
        Console.Write("Enter the file name: ");
        string userInput = Console.ReadLine();
        _fileName = userInput + ".txt";

        if (File.Exists(_fileName))
        {
            Console.WriteLine("This file already exists.");
            UpdateFile(_fileName);
            Console.WriteLine("Entries have been saved.");
        }

        else
        {
            using (StreamWriter sw = File.CreateText(_fileName))
            Console.WriteLine($"Success! {_fileName} has been created.");
            SaveFile(_fileName);
            Console.WriteLine("Entries have been saved.");
        }
    }

    public void SaveFile(string _fileName)
    {
        using (StreamWriter sw = new StreamWriter(_fileName))
        {
            foreach (Entry entry in _journal)
            {
                sw.WriteLine($"\n{entry._currentDate}\n{entry._writingPrompt}\n{entry._journalEntry}");
            }
        }
    }

    public void UpdateFile(string _fileName)
    {
        using (StreamWriter sw = new StreamWriter(_fileName, append: true))
        {
            foreach (Entry entry in _journal)
            {
                sw.WriteLine($"\n{entry._currentDate}\n{entry._writingPrompt}\n{entry._journalEntry}");
            }
        }
    }

    public void LoadFile()
    {
        Console.Write("Enter the file name: ");
        string userInput = Console.ReadLine();
        _fileName = userInput + ".txt";

        if (File.Exists(_fileName))
        {
            string content = File.ReadAllText(_fileName);
            Console.WriteLine("\nEntries:");
            Console.WriteLine(content);
        }

        else
        {
            Console.WriteLine("The file you are trying to load does not exist.");
        }
    }
}
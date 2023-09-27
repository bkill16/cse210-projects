using System;

public class Resume
{
    public string _name;
    public List<Job> _resume = new List<Job>();

    public void AddJob(Job j)
    {
        _resume.Add(j);
    }

    public void DisplayResume()
    {
        Console.WriteLine();
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _resume)
        {
            j.Display();
        }

        Console.WriteLine();
    }
}
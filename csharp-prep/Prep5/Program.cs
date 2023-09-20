using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
}
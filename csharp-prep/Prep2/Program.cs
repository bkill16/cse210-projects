using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string response = Console.ReadLine();
        int percent = int.Parse(response);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        if (percent >= 80)
        {
            letter = "B";
        }
        if (percent >= 70)
        {
            letter = "C";
        }
        if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade: {letter}");

        if (percent >= 70)
        {
            Console.Write("Congratulations! You passed this course.");
        }
        else
        {
            Console.Write("You did not pass this course. Do better next time.");
        }
    }
}
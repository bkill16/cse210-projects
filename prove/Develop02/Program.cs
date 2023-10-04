using System.Net;
using Microsoft.Win32.SafeHandles;
using System.IO;
using System.Text;
using System.Runtime.InteropServices;

class Program
{

    static void Main(string[] args)
    {

        Console.WriteLine();
        Console.WriteLine("Welcome to the Journal Program!");

        string choice = "";

        Journal journal = new Journal();
        Prompt wp = new Prompt();

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices by entering the number associated:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = wp.GeneratePrompt();

                Entry je = new Entry();
                string entryDate = GetCurrentDate();
                je._currentDate = entryDate;
                je._writingPrompt = prompt;

                Console.WriteLine($"\n{prompt}");
                string userEntry = Console.ReadLine();
                je._journalEntry = userEntry;
                journal._journal.Add(je);
            }

            else if (choice == "2")
            {
                journal.Display();
            }

            else if (choice == "3")
            {
                journal.LoadFile();
            }

            else if (choice == "4")
            {
                journal.CreateFile();
            }

            else if (choice == "5")
            {
                Console.WriteLine("Thank you. Goodbye.\n");
            }

            else
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }

    static string GetCurrentDate()
    {
        DateTime now = DateTime.Now;
        string currentDate = now.ToString("MM/dd/yyyy");
        return currentDate;
    }
}
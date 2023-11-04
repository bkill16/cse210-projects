using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        bool displayMenu = true;

        while (choice != "4")
        {
            if (displayMenu)
            {
                Console.WriteLine("Menu Options:");
                Console.WriteLine("1. Start Breathing Activity");
                Console.WriteLine("2. Start Reflecting Activity");
                Console.WriteLine("3. Start Listing Activity");
                Console.WriteLine("4. Quit");
                Console.WriteLine("Select a choice from the menu:");
            }
            
            choice = Console.ReadLine();

            // Breathing Activity
            if (choice == "1")
            {
                Breathing ba = new Breathing("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your \nbreathing.");
                ba.RunActivity(ref displayMenu, ba.PerformActivity);
            }

            // Reflecting Activity
            else if (choice == "2")
            {
                Reflecting ra = new Reflecting("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you \nrecognize the power you have and how you can use it in other aspects of your life.");
                ra.RunActivity(ref displayMenu, ra.PerformActivity);
            }

            // Listing Activity
            else if (choice == "3")
            {
                Listing la = new Listing("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                la.RunActivity(ref displayMenu, la.PerformActivity);
            }

            // Quit
            else if (choice == "4")
            {
                Console.WriteLine("\nThank you. Goodbye.\n");
                break;
            }

            else
            {
                Console.WriteLine("\nPlease enter a valid option.");
            }
        }
    }
}
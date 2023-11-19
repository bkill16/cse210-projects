using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    private static int _totalPoints;

    static void Main(string[] args)
    {
        Goal goal = new Goal();
        string choice = "";

        while (choice != "6")
        {
            Console.WriteLine();
            goal.DisplayTotalPoints();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                // Create new goal
                case "1":
                    goal.SelectGoalType();

                    if (goal.GetGoalChoice() == "1")
                    {
                        Simple s = new Simple(goal.GetGoalChoice());
                        s.CreateGoal();
                        goal.PopulateList(s);
                    }

                    if (goal.GetGoalChoice() == "2")
                    {
                        Eternal e = new Eternal(goal.GetGoalChoice());
                        e.CreateGoal();
                        goal.PopulateList(e);
                    }

                    if (goal.GetGoalChoice() == "3")
                    {
                        Checklist cl = new Checklist(goal.GetGoalChoice());
                        cl.CreateGoal();
                        goal.PopulateList(cl);
                    }

                    _totalPoints += goal.GetPoints();
                    break;

                // List goals
                case "2":
                    goal.DisplayGoalsList();
                    break;

                // Save goals
                case "3":
                    goal.CreateFile();
                    break;

                // Load goals
                case "4":
                    goal.LoadFile();
                    break;

                // Record event
                case "5":
                    goal.RecordEvent();
                    break;

                // Quit
                case "6":
                    Console.WriteLine("\nIn the words of Kim Kardashian, get your butt up and work.\n");
                    break;
            }
        }
    }
}
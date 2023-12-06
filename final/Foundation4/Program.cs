using System;

class Program
{
    static void Main(string[] args)
    {
        List <Activity> activities = new List<Activity>();

        Console.WriteLine();
        
        Running r1 = new Running("30 Nov 2023", 30, 3);
        activities.Add(r1);

        Swimming s1 = new Swimming("1 Dec 2023", 45, 30);
        activities.Add(s1);

        Cycling c1 = new Cycling("2 Dec 2033", 103, 15);
        activities.Add(c1);

        foreach (var activity in activities)
        {
            activity.DisplaySummary();
        }
    }
}
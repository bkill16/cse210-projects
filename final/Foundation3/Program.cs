using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("1959 NE Pacific St", "Seattle", "Washington", "98195");
        Lecture event1 = new Lecture("Performing CPR", "Learn how to save lives using proper CPR", "11/29/2023", "7:00pm", address1,"Meredith Grey", 50);
        Console.WriteLine("\nStandard Details:");
        event1.StandardDetails();
        Console.WriteLine("\nFull Details:");
        event1.FullDetails();
        Console.WriteLine("\nShort Description:");
        event1.ShortDescription();

        Address address2 = new Address("542 Sith Lord Way", "Jedi Temple", "Coruscant", "007567");
        Reception event2 = new Reception("Wedding Reception", "A celebration for the recent marriage of one Anakin Skywalker to one Padme Amidala", "12/2/2023", "6:30pm", address2, "obi1rocks@jedimail.com");
        Console.WriteLine("\nStandard Details:");
        event2.StandardDetails();
        Console.WriteLine("\nFull Details:");
        event2.FullDetails();
        Console.WriteLine("\nShort Description:");
        event2.ShortDescription();

        Address address3 = new Address("123 N Waterfall", "Shelley", "ID", "83274");
        Outdoor event3 = new Outdoor("Neighborhood Barbecue", "Come meet your neighbors and join us for some good food and some good fun!", "7/13/2024", "6:00pm", address3, "84F, Mostly Sunny");
        Console.WriteLine("\nStandard Details:");
        event3.StandardDetails();
        Console.WriteLine("\nFull Details:");
        event3.FullDetails();
        Console.WriteLine("\nShortDescription:");
        event3.ShortDescription();
        Console.WriteLine();
    }
}
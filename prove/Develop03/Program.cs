Reference reference = new Reference("Matthew", 11, 28, 30);
Scripture verse = new Scripture
("Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light.");

verse.SetReference(reference);

Console.WriteLine("\nWelcome to the Scripture Program!");
Console.WriteLine("Please press enter to continue. Type 'quit' to exit.\n");
verse.Display();

string userInput = Console.ReadLine();

if (!string.IsNullOrEmpty(userInput) && !string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Not valid. Please press enter or type 'quit'.\n");
}

while (!string.Equals(userInput, "quit", StringComparison.OrdinalIgnoreCase))
{
    Console.WriteLine("Please press enter to continue. Type 'quit' to exit.\n");
    string userReady = Console.ReadLine();

    if (string.IsNullOrEmpty(userReady))
    {
        Console.Clear();
        Console.WriteLine();
        verse.GetHiddenWord();
        verse.Display();
        Console.WriteLine();

        if (verse.IsCompletelyHidden())
        {
            Console.WriteLine("Good job!\n");
            break;
        }
    }  

    else if (string.Equals(userReady,"quit", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Thank you. Goodybye.\n");
        break;
    }

    else {
        Console.WriteLine("Not valid. Please press enter or type 'quit'.\n");
    }

}
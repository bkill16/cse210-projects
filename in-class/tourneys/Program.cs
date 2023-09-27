// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Player ronaldo = new Player("Christiano Ronaldo", 7);
ronaldo.Display();

Player brady = new Player("Tom Brady", 12);
brady.Display();

Team cardinals = new Team("Cardinals");
cardinals.AddPlayer(ronaldo);
cardinals.AddPlayer(brady);
cardinals.DisplayRoster();
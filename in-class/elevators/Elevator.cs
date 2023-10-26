using System.Data;

public class Elevator
{
    protected bool _doorOpen = false;
    protected string? _chosenElevator;

    public void OpenDoor()
    {
        _doorOpen = true;
        Console.WriteLine("Door open");
    }

    public void CloseDoor()
    {
        _doorOpen = false;
        Console.WriteLine("Door closed");
    }

    public void CallElevator()
    {   
        Console.WriteLine("Elevator 1, 2, or VIP");
        _chosenElevator = Console.ReadLine();

        if (_chosenElevator != "VIP")
        {
            MoveToFloor();
        }
    }

    public void MoveToFloor()
    {
        OpenDoor();
        Console.WriteLine("Enter floor: ");
        string stringfloor = Console.ReadLine();
        int floor = int.Parse(stringfloor);
        CloseDoor();
        if (floor >= 1 && floor < 31)
        {
            Console.WriteLine($"Going to floor {floor}");
            Console.WriteLine($"Arrived at floor {floor}");
        }
        else
        {
            Console.WriteLine("Invalid floor");
        }
    }
}
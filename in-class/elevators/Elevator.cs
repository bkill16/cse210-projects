using System.Data;

public class Elevator
{
    protected int _currentFloor = 1;
    protected bool _doorOpen = false;

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
        OpenDoor();
        Console.WriteLine("Enter floor: ");
        string stringfloor = Console.ReadLine();
        int floor = int.Parse(stringfloor);
        if (floor >= 1 && floor < 31)
        {
            Console.WriteLine($"Going to floor {floor}");
        }
        else
        {
            Console.WriteLine("Invalid floor");
        }
    }
}
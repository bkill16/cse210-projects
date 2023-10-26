public class VipElevator : Elevator
{
    private string _code = "1234";

    public void EnterCode()
    {

        base.CallElevator();
        if (_chosenElevator == "VIP")
        {
            Console.WriteLine("Enter code: ");
            string userResponse = Console.ReadLine();

            if (userResponse == _code)
            {
                MoveToFloor();
            }
        }
    }
}
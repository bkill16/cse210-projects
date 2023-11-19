using System.Runtime.CompilerServices;
using System.Security;

public class Eternal : Goal {

    public Eternal(string goalChoice)
    {
        SetGoalChoice(goalChoice);
    }

    public override string CheckBox()
    {
        if (_isComplete == true)
        {
            _checkbox = "[ ]";
            return _checkbox;
        }
        else
        {
            _checkbox = "[ ]";
            return _checkbox;
        }
    }

    public override string Serialize()
    {
        return base.Serialize();
    }

    public override string SerializeForUpdate()
    {
        return $"{base.SerializeForUpdate()}";
    }

    public void RecordEventEternal()
    {
        Console.Write("Goal completed y/n? ");
        string completion = Console.ReadLine();

        if (completion.ToLower() == "y")
        {
            _isComplete = true;
            _earnedPoints = int.Parse(_stringPoints);
            _totalPoints += _earnedPoints;

            Console.WriteLine($"Good job! {_earnedPoints} points added");
            Console.WriteLine("Remember to save!");
        }
        else
        {
            Console.WriteLine("Keep workin");
        }
    }
}

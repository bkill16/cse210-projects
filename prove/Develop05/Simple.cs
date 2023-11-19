using System.Runtime.CompilerServices;
using System.Security;

public class Simple : Goal
{

    public Simple(string goalChoice)
    {
        SetGoalChoice(goalChoice);
    }

    public override void LoadGoalFromData(string[] goalInfo)
    {
        base.LoadGoalFromData(goalInfo);
        _isComplete = bool.Parse(goalInfo[3]);
    }

    public override string Serialize()
    {
        return $"{base.Serialize()},{_isComplete}";
    }

    public override string SerializeForUpdate()
    {
        return $"{base.SerializeForUpdate()},{_isComplete}";
    }

    public void RecordEventSimple()
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
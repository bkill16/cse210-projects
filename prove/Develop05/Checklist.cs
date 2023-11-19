using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Checklist : Goal
{
    public int _target;
    public int _bonus;
    public int _timesCompleted = 0;

    public Checklist(string goalChoice)
    {
        SetGoalChoice(goalChoice);
    }

    public override void CreateGoal()
    {
        base.CreateGoal();

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        string stringTarget = Console.ReadLine();
        _target = int.Parse(stringTarget);
        Console.Write($"What is the bonus for accomplishing it {_target} times? ");
        string stringBonus = Console.ReadLine();
        _bonus = int.Parse(stringBonus);
    }

    public override string FormatGoal()
    {
        return $"{base.FormatGoal()} - Currently Completed PLACEHOLDER/{_target}";
    }

    public override void LoadGoalFromData(string[] goalInfo)
    {
        base.LoadGoalFromData(goalInfo);

        if (goalInfo.Length == 5)
        {
            _bonus = int.Parse(goalInfo[3]);
            _target = int.Parse(goalInfo[4]);
            _timesCompleted = int.Parse(goalInfo[5]);  // Uncomment if you need this property
        }
    }

    public override string Serialize()
    {
        return $"{base.Serialize()},{_bonus},{_target},{_timesCompleted}";
    }

    public override string SerializeForUpdate()
    {
        return $"{base.SerializeForUpdate()},{_bonus},{_target},{_timesCompleted}";
    }
}
using System.ComponentModel;
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
        return $"{base.FormatGoal()} - Currently Completed {_timesCompleted}/{_target}";
    }

    public override void LoadGoalFromData(string[] goalInfo)
    {
        base.LoadGoalFromData(goalInfo);

        if (goalInfo.Length >= 7)
        {
            _bonus = int.Parse(goalInfo[3]);
            _target = int.Parse(goalInfo[4]);
            _timesCompleted = int.Parse(goalInfo[5]);
            _isComplete = bool.Parse(goalInfo[6]);
        }
    }

    public override string Serialize()
    {
        return $"{base.Serialize()},{_bonus},{_target},{_timesCompleted},{_isComplete}";
    }

    public override string SerializeForUpdate()
    {
        return $"{base.SerializeForUpdate()},{_bonus},{_target},{_timesCompleted},{_isComplete}";
    }

    public void RecordEventChecklist()
    {
        Console.Write("Mark a completion y/n? ");
        string completion = Console.ReadLine();

        if (completion.ToLower() == "y")
        {
            _timesCompleted += 1;
            _earnedPoints = int.Parse(_stringPoints);
            _totalPoints += _earnedPoints;
            
            Console.WriteLine($"Good job! {_earnedPoints} points added");
            Console.WriteLine("Remember to save!");

            if (_timesCompleted == _target)
            {
                _isComplete = true;
                _totalPoints += _bonus;
                
                Console.WriteLine($"Good job! You earned {_bonus} bonus points");
                Console.WriteLine("Remember to save!");
            }
        }
        else
        {
            Console.WriteLine("Keep workin");
        }
    }
}

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
}
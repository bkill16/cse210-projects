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
}

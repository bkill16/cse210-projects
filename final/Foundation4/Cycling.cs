using System.Collections.Specialized;

public class Cycling : Activity {

    public Cycling(string date, double minutes, double speed) : base(date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double hours = _minutes / 60;
        _distance = _speed * hours;
        _distance = Math.Round(_distance, 2);
        return _distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        _pace = 60 / _speed;
        _pace = Math.Round(_pace, 2);
        return _pace;
    }
}
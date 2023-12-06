using System.ComponentModel.Design;

public class Activity {
    private string _date;
    protected double _minutes;
    protected double _distance;
    protected double _speed;
    protected double _pace;
    private string _summary;

    public Activity(string date, double minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public virtual double GetDistance()
    {
        _distance = Math.Round(_distance, 2);
        return _distance;
    }

    public virtual double GetSpeed()
    {
        double hours = _minutes / 60;
        _speed = _distance / hours;
        _speed = Math.Round(_speed, 2);
        return _speed;
    }

    public virtual double GetPace()
    {
        _pace = _minutes / _distance;
        _pace = Math.Round(_pace, 2);
        return _pace;
    }

    public string GetType(object obj)
    {
        Type type = obj.GetType();
        return type.Name;
    }

    public string GetSummary()
    {
        _summary = $"{_date} {GetType(this)} ({_minutes}min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile\n";
        return _summary;
    }

    public void DisplaySummary()
    {
        GetSummary();
        Console.WriteLine(_summary);
    }
}
public class Swimming : Activity {
    private int _laps;

    public Swimming(string date, double minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        _distance = (_laps * 50) / (1000 * 0.62);
        _distance = Math.Round(_distance, 2);
        return _distance;
    }
}
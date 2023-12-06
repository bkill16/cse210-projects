public class Running : Activity {

    public Running(string date, double minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }   
}
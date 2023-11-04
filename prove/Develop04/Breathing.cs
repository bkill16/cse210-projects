public class Breathing : Activity {
    public Breathing(string name, string description) : base(name, description)
    {

    }

    // Functionality of the Breathing activity
    public void BreatheInOut()
    {
        Console.WriteLine("Breathe in...");
        PauseSpinner(_duration);
        Console.WriteLine("\nBreathe out...");
        PauseSpinner(_duration);
    }

    // Set PerformActivity for this class
    public void PerformActivity()
    {
        BreatheInOut();
    }
}
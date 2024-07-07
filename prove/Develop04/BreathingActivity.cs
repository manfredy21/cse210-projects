
public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration): base(name, description, duration)
    {}

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        for (int i = 0; i < duration; i += 4)
        {
            Console.WriteLine("Breathe in...");
            ShowCountDown(2);
            Console.WriteLine("Breathe out...");
            ShowCountDown(2);
        }
        DisplayEndingMessage();
    }
}

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {_name} activity.");
        Console.WriteLine(_description);
        Console.Write("Enter activity duration (in seconds): ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Prepare yourself to begin {_name} activity...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($"You have completed the {_name} activity for {_duration} seconds.");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("/");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("-");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("\\");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
            Console.Write("|");
            System.Threading.Thread.Sleep(250);
            Console.Write("\b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000);
        }
    }
}
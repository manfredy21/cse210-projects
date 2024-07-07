
public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {}
    public void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine("Prompt: ");
        GetRandomPrompt();

        List<string> responses = GetListFromUser();
        Console.WriteLine($"You have listed {responses.Count} items.");

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);
    }

    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter your answer: ");
            string answer = Console.ReadLine();
            answers.Add(answer);
            _count++; 
        }
        Console.WriteLine($"This is the total answers that you wrote: {_count}"); 
        return answers;
    }
        

}

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRamdomPrompt()
    {
        Random rdn = new Random();
        int randIndex = rdn.Next(_prompts.Count);
        string randomPrompt = _prompts[randIndex];
        
        return randomPrompt;
    }
}
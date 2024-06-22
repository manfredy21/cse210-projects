
public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}#{entry._promptText}#{entry._entryText}");
            }
        }
        Console.WriteLine("Your Entry has been save");
    }

    public void LoadFromFile(string file)
    {
       using (StreamReader inputFile = new StreamReader(file))
       {
        string fileName = file;
        string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("#");
                Entry loadedEntry = new Entry()
                {
                    _date = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2],

                };
                _entries.Add(loadedEntry);
            }
        }
            
    }
}
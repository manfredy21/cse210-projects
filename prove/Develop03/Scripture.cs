public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words =  new List<Word>();
        ///here I split word for each spaces///
        string[] wordsList = text.Split(" ");
        foreach (string word in wordsList)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rdn = new Random();
        ///Here I created a new list to save all the words that we can see///
        List<Word> wordsCanSee = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                wordsCanSee.Add(word);
            }
        }
        ///In this one we count the words and word to hide to avoid eny repetition///
        int Wordcount = Math.Min(numberToHide, wordsCanSee.Count);
        for(int i = 0; i < Wordcount; i++)
        {
            int index = rdn.Next(wordsCanSee.Count);
            wordsCanSee[index].Hide();
            wordsCanSee.RemoveAt(index);
        }

    }

    public string GetDisplayText()
    {
        string text = "";
        foreach (Word word in _words)
        {
            if (text.Length > 0)
            {
                text += " ";
            }
            text += word.GetDisplayText();
        }
        return $"{_reference.GetDisplayText()} {text}";
    }

    public bool IsCompleteHidden()
    {
        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
    
}
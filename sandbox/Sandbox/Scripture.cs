public class Scripture
{
    public string reference { get; set; }

    public string text { get; set; }

    private List<Word> words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this.words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        if (words.Count - CountWordsHidden() < count)
        {
            count = words.Count - CountWordsHidden();
        }

        int hidden = 0;
        Random rand = new Random();
        while (hidden < count)
        {
            int index = rand.Next(words.Count);
            if (!words[index].IsHidden())
            {
                words[index].Hide();
                hidden++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }

    public int CountWordsHidden()
    {
        int count = 0;
        foreach (Word word in words)
        {
            if (word.IsHidden())
            {
                count++;
            }
        }
        return count;
    }

    public override string ToString()
    {
        return $"{reference}\n{text}";
    }

    public string ToStringAllHidden()
    {
        return $"{reference}\n{string.Join(" ", words.Select(word => word.IsHidden() ? new string('_', word.Text.Length) : word.Text))}";
    }
}
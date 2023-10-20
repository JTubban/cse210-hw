public class Scripture
{
    public string reference { get; set; }

    public string text { get; set; }

    private List<Word> _words;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
        this._words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int count)
    {
        if (_words.Count - CountWordsHidden() < count)
        {
            count = _words.Count - CountWordsHidden();
        }

        int hidden = 0;
        Random rand = new Random();
        while (hidden < count)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public int CountWordsHidden()
    {
        int count = 0;
        foreach (Word word in _words)
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
        return $"{reference}\n{string.Join(" ", _words.Select(word => word.IsHidden() ? new string('_', word.Text.Length) : word.Text))}";
    }
}
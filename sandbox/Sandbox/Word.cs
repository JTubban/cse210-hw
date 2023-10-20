public class Word
{
    private string _text;
    private bool _hidden;

    public Word(string text)
    {
        if (string.IsNullOrEmpty(text))
        {
            throw new ArgumentException("Text cannot be null or empty.", nameof(text));
        }
        
        this._text = text;
        this._hidden = false;
    }

    public string Text { get { return _text; } }

    public bool IsHidden() { return _hidden; }

    public void Hide() { _hidden = true; }

    public void Reveal() { _hidden = false; }
}
public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        this._word = word;
        this._hidden = false;
    }

    public string Text { get { return _word; } }
    public bool IsHidden() { return _hidden; }
    public void Hide() { _hidden = true; }
    public void Reveal() { _hidden = false; }
}
public class Scripture
{
    private Reference _reference = new Reference("Proverbs", 3, 5);
    private Reference _reference1 = new Reference("Proverbs", 3, 5, 6);
    private List<Word> _words = new List<Word>();

    private Word AddToList()
    {
        _words.Add("Trust in the Lord with all thine heart; and lean not unto thine own dunderstanding; In all thy ways acknowledge him, and he shall direct thy paths.");
    }
    public string GetPrompt()
    {
        AddToList();
        return _reference1.Prompt(_words[0]);
    }
}
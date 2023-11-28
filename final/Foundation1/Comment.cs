public class Comment
{
    public List<string> _commentList = new List<string>();

    public void AddComment(string name, string text)
    {
        _commentList.Add($"{name}: {text}");
    }

    public void DisplayComments()
    {
        foreach (string comment in _commentList)
        {
            Console.WriteLine(comment);
        }
    }
}
using System.Security.AccessControl;

public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public Comment _comment = new Comment();

    public void DisplayDetails()
    {
        Console.WriteLine($"\"{_title}\" by {_author} Around {_length} Seconds and {_comment._commentList.Count()} commmented.");
        Console.WriteLine("Comments:");
        _comment.DisplayComments();
    }
}
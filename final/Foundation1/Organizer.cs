public class Organizer
{
    public List<Video> _videos = new List<Video>();

    public void Display()
    {
        Console.Clear();

        foreach (Video d in _videos)
        {
            Console.WriteLine("");
            d.DisplayDetails();
        }
    }
}
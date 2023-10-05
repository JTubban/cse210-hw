public class Resume
{
    public string _myName = "Allison Rose";
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_myName}");
        Console.WriteLine("Jobs:");

        foreach(Job j in _jobs)
        {
            j.Display();
        }
    }
}
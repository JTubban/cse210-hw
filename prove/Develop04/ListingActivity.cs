public class ListingActivity: Activity
{
    private List<string> _listingActivityPrompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

     public ListingActivity(string activityName, string activityDescription): base(activityName, activityDescription)
    {

    }

    public void ListingExercise(string duration)
    {
        Console.WriteLine("Get ready...");
        // called spinner
        GetSpinner(); //3 sec
        Console.WriteLine();

        Random _generateRandom = new Random();
        int _randomNumber = _generateRandom.Next(0, _listingActivityPrompts.Count - 1);

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($" --- {_listingActivityPrompts[_randomNumber]} ---");
        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        // blank
        Console.WriteLine();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(int.Parse(duration));
        int counts = 0;
        while(DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            counts += 1;
        }
        Console.WriteLine($"You listed {counts} items!");
        Console.WriteLine();
 
        Console.WriteLine("Well done!!!");
        // called spinner
        GetSpinner();
        Console.WriteLine(GetConclusion(int.Parse(duration), _activityName));
        // called spinner
        GetSpinner();
    }
    
}
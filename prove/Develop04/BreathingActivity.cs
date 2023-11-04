public class BreathingActivity: Activity
{
    public BreathingActivity(string activityName, string startingMessage): base(activityName, startingMessage)
    {

    }

    public void BreathingExercise(string duration)
    {   
        Console.WriteLine("Get ready...");
        // called spinner
        GetSpinner();
        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(int.Parse(duration));
        
        while(DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }

            Console.WriteLine();

            Console.Write("Now breathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        Console.WriteLine("Well done!!!");

        // called spinner
        GetSpinner();
        Console.WriteLine(GetConclusion(int.Parse(duration), _activityName));
        // called spinner
        GetSpinner();
    }
}
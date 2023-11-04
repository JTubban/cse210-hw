public class ReflectingActivity: Activity
{
    private List<string> _listOfPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _reflectionQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string activityName, string activityDescription): base(activityName, activityDescription)
    {

    }
    public void ReflectingExercise(string duration)
    {
        Console.WriteLine("Get ready...");
        // called spinner
        GetSpinner();
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:\n");
        // generate random
        Random _generateRandom = new Random();
        int randomNumber1 = _generateRandom.Next(0, _listOfPrompts.Count - 1);
        // display random prompts
        Console.WriteLine($" --- {_listOfPrompts[randomNumber1]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(int.Parse(duration));

        while (DateTime.Now < endTime)
        {
            int randomNumber2 = _generateRandom.Next(0, _reflectionQuestions.Count - 1);
            Console.Write($"> {_reflectionQuestions[randomNumber2]}");
            GetSpinner(5);
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
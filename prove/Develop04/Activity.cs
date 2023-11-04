public class Activity
{
    protected string _activityName = "";
    private string _activityDescription = "";
    protected int _counts = 0;

    private List<string> _spinnerList = new List<string>
    {
        "|", "/", "-", "\\", "|", "/", "-", "\\"
    };
    
    public Activity()
    {
        _activityName = "";
        _activityDescription = "";
    }

    public Activity(string activityName, string activityDescription)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
    }

    public string GetStartingMessage()
    {
        return $"Welcome to the {_activityName} Activity.\n\n{_activityDescription}";
    }

    public string DurationMessage()
    {
        return "How long, in seconds, would you like for your session? ";
    }

    // spinner
    public void GetSpinner(int spinDuration = 3)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(spinDuration);

        while (DateTime.Now < endTime)
        {
            foreach(string s in _spinnerList)
            {
                Console.Write(s);
                Thread.Sleep(200);
                Console.Write("\b \b");
            }
        }
    }

    public string GetConclusion(int duration, string activityName)
    {
        return $"You have completed another {duration} seconds of the {activityName} Activity.";
    }
}
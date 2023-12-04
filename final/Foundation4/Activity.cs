using System.Net.Http.Headers;
using Microsoft.VisualBasic;

public class Activity
{
    protected string _currentDate;
    protected int _durationInMinutes;

    public Activity(int durationInMinutes)
    {
        this._currentDate = SetDate();
        this._durationInMinutes = durationInMinutes;
    }

    private string SetDate()
    {
        DateTime currentDate = DateTime.Now;
        return currentDate.ToShortDateString();
    }

    public virtual void GetSummary()
    {
        
    }
}
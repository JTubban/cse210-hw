public class GalaForTheArts : Event
{
    public GalaForTheArts(string eventTitle, string description, string date, string time) : base(eventTitle, description, date, time)
    {

    }

    public string StandardDetails()
    {
        return $@"
Event Title: {_eventTitle}

Description:
{_description}

Date:
{_date}

Time:
{_time}

Venue:
{DisplayAddress()}
        ";
    }
}
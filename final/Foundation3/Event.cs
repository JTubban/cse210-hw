using System.Reflection.Metadata;

public class Event
{
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _weatherAdvisory;
    protected List<Address> _eventAddress = new List<Address>();

    public Event(string eventTitle, string description, string date)
    {
        this._eventTitle = eventTitle;
        this._description = description;
        this._date = date;
    }
    public Event(string eventTitle, string description, string date, string weatherAdvisory)
    {
        this._eventTitle = eventTitle;
        this._description = description;
        this._date = date;
        this._weatherAdvisory = weatherAdvisory;
    }
    public Event(string eventTitle, string description, string date, string time, string weatherAdvisory)
    {
        this._eventTitle = eventTitle;
        this._description = description;
        this._date = date;
        this._time = time;
        this._weatherAdvisory = weatherAdvisory;
    }

    public void AddAddress(Address address)
    {
        _eventAddress.Add(address);
    }

    public string DisplayAddress()
    {
        int index = 0;
        return _eventAddress[index].GetAddress();
    }
}
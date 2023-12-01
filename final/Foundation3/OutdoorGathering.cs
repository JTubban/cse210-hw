public class OutdoorGathering : Event
{
    private string _typeOfEvent;
    private string _location;

    public OutdoorGathering(string eventTitle, string description, string date, string typeOfEvent, string weatherAdvisory, string location) : base(eventTitle, description, date, weatherAdvisory)
    {
        _typeOfEvent = typeOfEvent;
        _location = location;
    }

    public string ShortDescription()
    {
        return $@"
Event Title: {_eventTitle}

Type of Event: {_typeOfEvent}

Description:
{_description}

Date:
{_date}

Location:
{_location}

Weather Advisory:
{_weatherAdvisory}

Highlights:

    Guided Nature Walks
    Outdoor Yoga Sessions
    Bird Watching Workshops
    Nature-inspired Art and Craft Stations
    Picnic Area with Local Food Vendors
    Live Music from Local Bands

Important Notes:

    No attendee limit, so feel free to invite your friends and family.
    Please check the weather forecast closer to the event date for any updates.
    Bring your own picnic blanket or lawn chair for a comfortable experience.
    NatureFest is a sustainable event, so remember to dispose of waste responsibly.

Let's come together to embrace the beauty of nature at NatureFest 2023! See you there!
        ";
    }
}
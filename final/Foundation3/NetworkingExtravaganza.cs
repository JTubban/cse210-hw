public class NetworkingExtravaganza : Event
{
    private string _rsvpRegistrationDeadline;
    private string _eventWebsite;
    private string _rsvpEmail;
    
    public NetworkingExtravaganza(string eventTitle, string description, string date, string time, string rsvpRegistrationDeadline, string eventWebsite, string rsvpEmail, string weatherAdvisory) : base(eventTitle, description, date, time, weatherAdvisory)
    {
        this._rsvpRegistrationDeadline = rsvpRegistrationDeadline;
        this._eventWebsite = eventWebsite;
        this._rsvpEmail = rsvpEmail;
    }

    public string FullDetails()
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

RSVP/Registration Deadline: {_rsvpRegistrationDeadline}

Highlights:

    Informal Networking Sessions
    Guest Speakers
    Refreshments

Guest Speaker:

    Elon Musk
    Topic: Navigating the Future: Building Successful Connections
    Capacity: Limited seating, so early registration is encouraged.

RSVP Email: {_rsvpEmail}

Weather Statement:
{_weatherAdvisory}

RSVP/Registration Informarion:
To attend this exclusive event, please RSVP or register by {_rsvpRegistrationDeadline}. Your registration helps
us plan for a memorable evening.

How to RSVP/Register:

Email your RSVP to {_rsvpEmail} with the subject line (Networking Extravaganza RSVP).
Visit out event wensite at {_eventWebsite}
Click on the RSVP/Register button and follow the instructions.
    
Don't miss this opportunity to make meaningful connections and enjoy an evening of networking
in a sophisticated setting. We look forward to seeing you there!

Best Regards,
Event Organization/Mr. Bean
        ";
    }
}
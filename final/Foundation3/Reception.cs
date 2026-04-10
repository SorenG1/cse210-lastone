using System;

public class Reception : Event
{
    private string _rsvpEmail;

    //Constructor
    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail);
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail; // still couldn't figure out what the error is here...
    }

    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nRSVP Email: {_rsvpEmail}";
    }

    public string GetShort()
    {
        return GetShortDescription("Reception");
    }
}
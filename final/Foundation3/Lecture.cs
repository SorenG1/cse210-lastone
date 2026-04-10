using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    //constructor
    public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // Details
    public string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }

    public string GetShort()
    {
        return GetShortDescription("Lecture");
    }
}
using System;
using System.Collections.Generic;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date, TimeSpan time, Address address, string speaker, int capacity)
     : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string Speaker
    {
        get { return _speaker; }
        set { _speaker = value; }
    }

    public int Capacity
    {
        get { return _capacity; }
        set { _capacity = value; }
    }

    public override string GetFullDetails()
    {
        string baseDetails = GetStandardDetails();
        return $"{baseDetails}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}
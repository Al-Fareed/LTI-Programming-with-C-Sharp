using System;
using System.Collections.Generic;

class Event
{
    private string _name;
    private string _detail;
    private string _type;
    private string _organizer;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public HallBooking HallBooking
    {
        get { return this.HallBooking; }
        set { this.HallBooking = value; }
    }

    public string Detail
    {
        get { return this._detail; }
        set { this._detail = value; }
    }

    public string Type
    {
        get { return this._type; }
        set { this._type = value; }
    }

    public string Organizer
    {
        get { return this._organizer; }
        set { this._organizer = value; }
    }

    public Event()
    {
    }

    public Event(string _name, string _detail, string _type, string _organizer)
    {
        this._name = _name;
        this._detail = _detail;
        this._type = _type;
        this._organizer = _organizer;
    }
    
    public static List<Event> GetAllEvents()
    {
        List<Event> events = new List<Event>();
        events.Add(new Event("SARC Conference", "International Conference", "Conference", "Peter"));
        events.Add(new Event("Birthday party", "Albert's Birthday party", "Birthday", "Daniel"));
        events.Add(new Event("Christmas Eve", "Christmas celebration", "Stage show", "John"));
        events.Add(new Event("New Year Eve", "New Year celebration", "Stage show", "Smith"));
        events.Add(new Event("Positive Psychology in Practice", "International Conference", "Conference", "Merida"));
        return events;
    }
}
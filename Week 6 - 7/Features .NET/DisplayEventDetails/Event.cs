using System;
using System.Collections.Generic;
public class Event
{
    private string _eventName;
    private string _organiserName;
    private double _eventCost;
    public Event(){}
    public Event(string eventName, string organiserName, double eventCost)
    {
        _eventName = eventName;
        _organiserName = organiserName;
        _eventCost = eventCost;
    }
    public string EventName
    {
        get => _eventName;
        set => _eventName = value;
    }
    public string OrganiserName
    {
        get => _organiserName;
        set => _organiserName = value;
    }
    public double EventCost
    {
        get => _eventCost;
        set => _eventCost = value;
    }
    
    public void Display(List<Event> eventList)
    {
        Console.WriteLine("List of events");
        foreach (Event events in eventList)
        {
            Console.WriteLine("{0}|{1}|{2}",events.EventName,events.OrganiserName,events.EventCost);
        }
    }
    public override string ToString()
    {
        return "";
    }
}
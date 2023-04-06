using System;
using System.Collections.Generic;
public class Event
{
    private string _name;
    private string _type;
    private string _organizer;
    public Event(string _name, string _type, string _organizer)
    {
        this._name = _name;
        this._type = _type;
        this._organizer = _organizer;
    }
    public Event(){}
    public string Name{ get=>_name;}
    public string Type{get=>_type;}
    public string Organizer{get=>_organizer;}

    public override string ToString(){
        return "";
    }
    public void Display(List<Event> eventList){
        Console.WriteLine("{0,-15}{1,-15}{2,-15}","EventName","EventType","EventOrganizer");
        foreach (Event events in eventList)
        {
            Console.WriteLine("{0,-15}{1,-15}{2,-15}",events._name, events._type, events._organizer);
        }
    }
}
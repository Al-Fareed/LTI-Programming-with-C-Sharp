using System;
public class Event
{
    protected string _name;
    protected DateTime _date;
    protected string _type;
    protected string _organizer;
    //Fill your code
    public Event()
    {
        
    }
public Event(string _name, DateTime _date, string _type, string _organizer)
    {
        this._name = _name;
        this._date = _date;
        this._type = _type;
        this._organizer = _organizer;
    }


}
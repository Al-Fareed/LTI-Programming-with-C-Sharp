using System;
public class Event
{
    private string _name;
    private string _type;
    private string _organizer;
    public string Name
    {
        get => _name;
        set => _name =value;
    }
    public string Type
    {
        get => _type;
        set => _type =value;

    }
    public string Organizer
    {
        get => _organizer;
        set => _organizer =value;
    }
    public Event(){}
    public Event(string name, string type, string organizer)
    {
         _name = name;
         _type = type;
         _organizer = organizer;
    }

    public virtual void Display()
    {
        Console.WriteLine("Event Name: {0}\nEvent organizer: {1}\nEvent Type: {2}", Name,Organizer, Type);
    }
}
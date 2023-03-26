using System;
public class Exhibition : Event
{
    private string _stallType;
    //Fill your code
    public Exhibition()
    {
        
    }
    public Exhibition(string _name, DateTime _date, string _type, string _organizer, string _stallType)
    {
        base._name = _name;
        base._date = _date;
        base._type = _type;
        base._organizer = _organizer;
        this._stallType = _stallType;
    }
    public void Display(){
        Console.WriteLine("Event Name: {0}\nEvent Date: "+_date.ToString("dd/MM/yyyy")+"\nEvent Organizer: {1}\nEvent Type: {2}\nStall Type: {3}",_name,_organizer,_type,_stallType);
    }
}
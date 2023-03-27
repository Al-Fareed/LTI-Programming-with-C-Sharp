using System;
public class StageEvent : Event
{
    private string _showType;
    //Fill your code
     public StageEvent(){}
    public StageEvent(string _name, DateTime _date, string _type, string _organizer, string _showType)
    {
        base._name = _name;
        base._date = _date;
        base._type = _type;
        base._organizer = _organizer;
        this._showType = _showType;
    }
    public void Display(){
        Console.WriteLine("Event Name: {0}\nEvent Date: "+_date.ToString("dd/MM/yyyy")+"\nEvent Organizer: {1}\nEvent Type: {2}\nShow Type: {3}",_name,_organizer,_type,_showType);
    }
}
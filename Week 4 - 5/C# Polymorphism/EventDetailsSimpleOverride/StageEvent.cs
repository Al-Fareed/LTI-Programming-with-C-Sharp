using System;
public class StageEvent : Event
{
    //Fill your code here
    private int _totalShow;
    private int _seatsPerShow;
    public string org;
    public StageEvent(){}
    public StageEvent(string _name, string _detail, string _organizer, int _totalShow, int _seats):base(_name,_detail,_organizer)
    {
        this._totalShow = _totalShow;
        _seatsPerShow = _seats;
        this.org = _organizer;
    }
    
    public override void TotalCredit()
    {
        //Fill your code here
        base.TotalCredit();
        int credits=(_totalShow*_seatsPerShow)*100;
        Console.WriteLine($"Total Credit Gained is {credits}");

    }
    public override string ToString()
    {
        //Fill your code here 
         return base.ToString() + $"Event Organizeer : {org}\nTotal Events : {_totalShow}\nTotal Seats : {_seatsPerShow}";
    }
}
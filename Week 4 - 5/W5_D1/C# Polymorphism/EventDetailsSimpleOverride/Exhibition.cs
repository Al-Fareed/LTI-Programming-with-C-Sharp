using System;
public class Exhibition : Event
{
    //Fill your code here
    private int _stallCount;
    string org;
    public Exhibition() { }
    public Exhibition(string _name, string _detail, string _organizer, int _stallCount)
    : base(_name, _detail, _organizer)
    {
        this._stallCount = _stallCount;
        this.org = _organizer;
    }
    int credits;
    public override void TotalCredit()
    {
        //Fill your code here
        base.TotalCredit();
        credits = _stallCount * 50;
        Console.WriteLine($"Total Credit Gained is {credits}");
    }
    public override string ToString()
    {
        //Fill your code here
        return base.ToString()+$"Event Organizer : {org}\nStall Count : {_stallCount}";
    }

}
using System;
public class Exhibition : Event
{
    private int _noOfStalls;

    public Exhibition(string _name, string _type, string _organizer, int noOfStalls)
    : base(_name, _type, _organizer)
    {
        _noOfStalls = noOfStalls;
    }
    public int NoOfStalls{
        set => _noOfStalls = value;
        get => _noOfStalls;
    }

    public override void Display()
    {
        base.Display();
        Console.WriteLine("No of Stalls: {0}",NoOfStalls);
    }
}
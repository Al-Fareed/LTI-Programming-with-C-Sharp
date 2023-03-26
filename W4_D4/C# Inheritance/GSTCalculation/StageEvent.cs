using System;
class StageEvent : Event //Fill your code here
{
    //Fill your code here
    private static int _gst = 15;
    private int _noOfSeats;
    public StageEvent()
    {
        
    }
    public StageEvent(string _name, string _type, double _costPerDay, int _noOfDays, int _noOfSeats)
    {
        base._name=_name;
        base._type=_type;
        base._costPerDay= _costPerDay;
        base._noOfDays= _noOfDays;
        this._noOfSeats=_noOfSeats;
    }
    double cost;
    public double totalCost()
    {
        //Fill your code here
        // cost=_costPerDay*_noOfDays;//4500
        double GrossCost=((0.15*cost)+cost);
        return GrossCost;
    }

    public override string ToString()
    {
        //Fill your code here
        Console.WriteLine("Name:{0}\nType:{1}\nNumber of seats:{2}",_name,_type,_noOfSeats);
        Console.WriteLine("Total amount:"+string.Format("{0:0.00}",totalCost()));
        return "";
    }
}
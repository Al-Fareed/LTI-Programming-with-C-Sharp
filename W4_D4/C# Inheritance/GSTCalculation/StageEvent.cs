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
        cost=_costPerDay*_noOfDays;
        double GrossCost=((0.15*cost)+cost);
        return GrossCost;
    }

    public override string ToString()
    {
        //Fill your code here
        return base.ToString()+"\nNumber of seats:"+_noOfSeats+"\nTotal amount:"+totalCost().ToString("F2");
    }
}
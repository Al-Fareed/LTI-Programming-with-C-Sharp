using System;
class Exhibition : Event //Fill your code here
{
    //Fill your code here
    private static int _gst = 5;
    private int _noOfStalls;

    public Exhibition()
    {
        
    }
    public Exhibition(string _name, string _type, double _costPerDay, int _noOfDays, int _noOfStalls)
    {
        base._name=_name;
        base._type=_type;
        base._costPerDay= _costPerDay;
        base._noOfDays= _noOfDays;
        this._noOfStalls = _noOfStalls;
    }
    double cost;
    public double totalCost()
    {
        //Fill your code here
        cost=_costPerDay*_noOfDays;
        double Gross=((0.05*cost)+cost);
        return Gross;
    }

    public override string ToString()
    {
        //Fill your code here
        return base.ToString()+"\nNumber of stalls:"+_noOfStalls+"\nTotal amount:"+totalCost().ToString("F2");
    }
}
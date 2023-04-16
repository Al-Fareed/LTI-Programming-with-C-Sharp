using System;

class ExecutiveStall : IStall
{
    private string _name;
    private string _details;
    private double _cost;
    private string _ownerName;
    private int _numberOfTVSet;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }

    public string Details
    {
        get { return this._details; }
        set { this._details = value; }
    }

    public double Cost
    {
        get { return this._cost; }
        set { this._cost = value; }
    }

    public string OwnerName
    {
        get { return this._ownerName; }
        set { this._ownerName = value; }
    }

    public int NumberOfTVSet
    {
        get { return this._numberOfTVSet; }
        set { this._numberOfTVSet = value; }
    }

    public ExecutiveStall(){}

    public ExecutiveStall(string _name, string _details, double _cost, string _ownerName, int _numberOfTV)
    {
        this._name = _name;
        this._details = _details;
        this._cost = _cost;
        this._ownerName = _ownerName;
        this._numberOfTVSet = _numberOfTV;
    }

    //fill code here
    public void display(){
        Console.WriteLine($"Stall name:{_name}\nDetails:{_details}\nCost:{_cost}.00\nOwner:{_ownerName}\nNumber of TV set:{_numberOfTVSet}");
         
    }
}
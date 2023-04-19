using System;
using System.Collections.Generic;

class Hall
{
    private string _name;
    private long _mobileNumber;
    private double _costPerDay;
    private string _owner;

    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }
    public long MobileNumber
    {
        get { return this._mobileNumber; }
        set { this._mobileNumber = value; }
    }
    public double CostPerDay
    {
        get { return this._costPerDay; }
        set { this._costPerDay = value; }
    }
    public string Owner
    {
        get { return this._owner; }
        set { this._owner = value; }
    }

    public Hall(string _name, long _mobileNumber, double _costPerDay, string _owner)
    {
        this._name = _name;
        this._mobileNumber = _mobileNumber;
        this._costPerDay = _costPerDay;
        this._owner = _owner;
    }

    public Hall() { }
    
    public static List<Hall> GetAllHalls()
    {
        List<Hall> halls = new List<Hall>();
        halls.Add(new Hall("The Great Hall", 9874563210, 1000.00, "Daniel"));
        halls.Add(new Hall("The Royal Hall", 9865321470, 1500.00, "Cassandra"));
        halls.Add(new Hall("The Gibson Hall", 8796543211, 750.00, "Abraham"));
        halls.Add(new Hall("Queen's Hall", 8745693221, 5000.00, "William"));
        return halls;
    }
}
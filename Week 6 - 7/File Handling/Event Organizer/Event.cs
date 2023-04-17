using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Event
{
    private string _name;
    private string _type;
    private double _cost;
    private string _organizer;
    public Event(string name, string type, double cost, string organizer)
    {
        this._name = name;
        this._type = type;
        this._cost = cost;
        this._organizer = organizer;
    }
    public string Name
    {
        get { return this._name; }
        set { this._name = value; }
    }
    public string Type
    {
        get { return this._type; }
        set { this._type = value; }
    }
    public double Cost
    {
        get { return this._cost; }
        set { this._cost = value; }
    }
    public string Organizer
    {
        get { return this._organizer; }
        set { this._organizer = value; }
    }
    public override string ToString()
    {
        return "";
    }
}

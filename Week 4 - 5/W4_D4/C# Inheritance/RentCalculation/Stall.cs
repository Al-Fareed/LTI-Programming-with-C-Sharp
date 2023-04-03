using System;
public class Stall
{
    protected string _name;
    protected string _detail;
    protected string _owner;
    protected double _costPerDay;
    public Stall() { }
    public Stall(string _name, string _detail, string _owner, double _costPerDay)
    {
        this._name = _name;
        this._detail = _detail;
        this._owner = _owner;
        this._costPerDay = _costPerDay;
    }
 
    double rent;

    public virtual double calculateRent(int days)
    {
        return rent = days * (_costPerDay);
    }
    public virtual string ToString()
    {
        //Fill Your Code Here
        Console.WriteLine("Name : {0}", _name);
        Console.WriteLine("Detail : {0}", _detail);
        Console.WriteLine("Owner : {0}", _owner);
        Console.WriteLine("Cost Per Day : {0}", _costPerDay);
        
        return "";
    }

}
using System;
public class GoldStall : Stall
{
    public double _discount;
    public GoldStall() { }
    public GoldStall(string _name, string _detail, string _owner, double _costPerDay, double _discount) : base(_name, _detail, _owner, _costPerDay)
    {
        this._discount = _discount;
    }
    double rent;

    public override double calculateRent(int days)
    {
        rent = (days * _costPerDay) - ((days * _costPerDay) * _discount / 100);
        return rent;
    }
    public override string ToString()
    {
        //Fill your code here
        Console.WriteLine("Name : {0}", _name);
        Console.WriteLine("Detail : {0}", _detail);
        Console.WriteLine("Owner : {0}", _owner);
        Console.WriteLine("Cost Per Day : {0}", _costPerDay);
        
        return "";
    }
}
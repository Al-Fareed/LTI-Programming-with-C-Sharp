using System;
class ItemType : Program
{
    private string _name;
    private double _costPerDay, _deposit;
    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public double CostPerDay
    {
        get => _costPerDay;
        set => _costPerDay = value;
    }
    public double Deposit
    {
        get => _deposit;
        set => _deposit = value;
    }
    public void Display()
    {
        Console.WriteLine("Item type details\nName:" + _name);
        Console.WriteLine("CostPerDay:" + string.Format("{0:0.00}", _costPerDay));
        Console.WriteLine("Deposit:" + string.Format("{0:0.00}", _deposit));
    }
}

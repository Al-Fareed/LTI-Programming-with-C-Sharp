public class ItemType
{
    private string _name;
    private double _deposit;
    private double _costPerDay;

    public string Name
    {
        get => _name;
        set => _name = value;
    }
    public double Deposit
    {
        get => _deposit;
        set => _deposit = value;
    }
    public double CostPerDay
    {
        get => _costPerDay;
        set => _costPerDay = value;
    }

    public ItemType(string _name, double _deposit, double _costPerDay)
    {
        Name = _name;
        Deposit = _deposit;
        CostPerDay = _costPerDay;
    }

}
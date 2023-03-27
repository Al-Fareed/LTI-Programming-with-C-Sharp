public class Stall
{
    protected string _name;
    protected string _detail;
    protected string _owner;
    protected double _costPerDay;

    public Stall(){
        
    }
    public Stall(string _name, string _detail, string _owner, double _costPerDay)
    {
        this._name=_name;
        this._detail=_detail;
        this._owner=_owner;
        this._costPerDay=_costPerDay;
    }
        double rent;

    public virtual double CalculateRent(int days){
        rent = days*( _costPerDay/100);
    }
    public override string ToString()
	{
	   //Fill Your Code Here
      
       Console.WriteLine("Your Total Cost {0}",rent);
	   return "";
	}
    public string Name{get;}
    public string Detail{get;}
    public string Owner{get;}
    public double CostPerDay{get;}
}
using System;
public class PlatinumStall : GoldStall
{
	public PlatinumStall(){}
	public PlatinumStall(string _name, string _detail, string _owner, double _costPerDay, double _discount, string _coupon)
	: base(_name,_detail,_owner,_costPerDay,_discount)
	{
		this._coupon=_coupon;
	}
	string _coupon;
double rent;
    public override  double  CalculateRent(int days){
        rent=(days * CostPerDay) - ((days * CostPerDay) * _discount/100);
		return rent;
    }
    	public override string ToString()
	{
	   	//Fill your code here
        Console.WriteLine("Your Total Cost  {0}", rent );
		return "";
	}
}
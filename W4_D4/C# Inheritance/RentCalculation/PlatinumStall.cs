public class PlatinumStall 
{
double rent;
    public override double  calculateRent(int days){
        rent=(days * costPerDay) - ((days * costPerDay) * discount/100);
    }
    	public override string ToString()
	{
	   	//Fill your code here
        Console.WriteLine("Your Total Cost  {0}", rent );
		return "";
	}
}
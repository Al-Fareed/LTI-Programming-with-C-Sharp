using System;
public class Program{
    public static void Main(){
        Console.WriteLine("Select your choice...\n1. Make My Trip\n2. Trivago\n3. Clear Trip");
        int ch = Convert.ToInt32(Console.ReadLine());
        string city;
        switch(ch)
        {
			case 1:
                MakeMyTrip mmt=new MakeMyTrip();
				Console.WriteLine("Available Cities:");
                mmt.CityList();
				Console.WriteLine("Enter a city to view hotels:");
                city=Console.ReadLine();
                mmt.ShowTariff(city);
				break;
			case 2:
                Trivago tmt=new Trivago();
				Console.WriteLine("Available Cities:");
                tmt.CityList();
				Console.WriteLine("Enter a city to view hotels:");
                city=Console.ReadLine();
                tmt.ShowTariff(city);
				break;
			case 3:
                ClearTrip mct=new ClearTrip();
				Console.WriteLine("Available Cities:");
                mct.CityList();
				Console.WriteLine("Enter a city to view hotels:");
                city=Console.ReadLine();
                mct.ShowTariff(city);
				break;
        }
    }
}

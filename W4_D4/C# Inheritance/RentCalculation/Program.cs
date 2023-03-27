class Program
{
    static void Display(string name,string detail,string owner, double costPerDay){
         Console.WriteLine("Name : {0}",name);
       Console.WriteLine("Detail : {0}",detail);
       Console.WriteLine("Owner : {0}",owner);
       Console.WriteLine("Cost Per Day : {0}",costPerDay);
    }
    static void Main()


    {
        Console.WriteLine("Enter stall name");
        string stallName = Console.ReadLine();
        Console.WriteLine("Enter stall detail");
        string stallDetail = Console.ReadLine();
        Console.WriteLine("Enter stall owner name");
        string ownerName = Console.ReadLine();
        Console.WriteLine("Enter cost per day");
        double costPerDay = double.Parse(Console.ReadLine());
        Console.WriteLine("1.Stall 2.GoldStall 3.PlatinumStall");
        int type = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Total Number of Days");
        int noOfDays = int.Parse(Console.ReadLine());

        if (type == 1)
        {
            Stall s = new Stall(stallName, stallDetail, ownerName, costPerDay);
            s.CalculateRent(noOfDays);
                Display(stallName, stallDetail, ownerName, costPerDay);
            s.ToString();
        }
        else if (type == 2 || type == 3)
        {
            Console.WriteLine("Enter discount percentage");
            double discountPercentage = double.Parse(Console.ReadLine());
            if (type == 2)
            {
                GoldStall g=new GoldStall(stallName, stallDetail, ownerName, costPerDay,discountPercentage);
                g.CalculateRent(noOfDays);
                Display(stallName, stallDetail, ownerName, costPerDay);
                g.ToString();
            }
            else
            {
                Console.WriteLine("Coupon Yes/No");
                string coupon = Console.ReadLine();
                PlatinumStall p=new PlatinumStall();
                Display(stallName, stallDetail, ownerName, costPerDay);
                if(coupon == "yes"){
                   int rent= p.ToString();
                   Console.WriteLine("Your Total Cost {0}",(rent/2));
                }else{
                    int rent= p.ToString();
                    Console.WriteLine("Your Total Cost {0}",rent);
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid choice");
        }
    }
}
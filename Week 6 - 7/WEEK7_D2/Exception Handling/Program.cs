using System;
class Program
{
    static void Main(string[] args){
        try
        {
            Console.WriteLine("Enter the item type name");
            string iName = Console.ReadLine();

            Console.WriteLine("Enter the deposit");
            int deposit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cost per day");
            int costPerDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Item type details\nName:"+iName);
            Console.WriteLine("Deposit:"+deposit);
            Console.WriteLine("Cost per day:"+costPerDay);
        }
        catch (System.Exception)
        {
            Console.WriteLine("Input string was not in the correct format");
        }
    }
}
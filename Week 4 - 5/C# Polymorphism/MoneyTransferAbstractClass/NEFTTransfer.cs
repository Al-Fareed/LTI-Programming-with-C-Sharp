using System;
public class NEFTTransfer : FundTransfer 
{

    DateTime _date;
    DateTime _start = DateTime.ParseExact("09:00:00 AM", "hh:mm:ss tt", null);
    DateTime _end = DateTime.ParseExact("06:00:00 PM", "hh:mm:ss tt", null);

    public override void Transfer(string accountNumber, double amount)
    {
        Console.WriteLine("Enter the Transaction time(hh:mm:ss tt):");
        string input = Console.ReadLine();
        Console.WriteLine($"The Transaction Time is {input}");
        DateTime time;
        if (DateTime.TryParseExact(input, "hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out time))
        {
            if (time >= _start && time <= _end)
            {
                Console.WriteLine("The Amount is transferred using NEFT Transfer");

                Console.WriteLine($"Rs.{amount} is transferred to the Account Number {accountNumber} successfully");
            }
            else
            {
                Console.WriteLine("NEFT Transfer is applicable between 9.00 AM and 6.00 PM.");
            }
        }
        //Fill your code here
        else
        {
            Console.WriteLine("Invalid data");
        }
    }
}
using System;
public class NEFTTransfer
{

    DateTime _date;
    DateTime _start = DateTime.ParseExact("09:00:00 AM", "hh:mm:ss tt", null);
    DateTime _end = DateTime.ParseExact("06:00:00 PM", "hh:mm:ss tt", null);

    public void Transfer(string accountNumber, double amount)
    {
        Console.WriteLine("Enter the Transaction time(hh:mm:ss tt):");
        string dt=Console.ReadLine();
        Console.WriteLine($"The Transaction Time is {dt}");
        DateTime time = DateTime.ParseExact(dt, "hh:mm:ss tt", null);
        //Fill your code here
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
}
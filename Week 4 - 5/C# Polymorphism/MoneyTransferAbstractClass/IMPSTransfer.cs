 using System;
public class IMPSTransfer : FundTransfer 
{
    public override void Transfer(string accountNumber, double amount)
    {
        //Fill your code here
        double charge = (amount*0.02);
        Console.WriteLine("The Amount is transferred using IMPS Transfer");
        Console.WriteLine($"Rs.{amount} is transferred to the Account Number {accountNumber} successfully");
        Console.WriteLine($"The Service charge for this transaction is Rs.{charge}");
    }
}
 using System;
public class RTGSTransfer : FundTransfer 
{
    public override void Transfer(string accountNumber, double amount)
    {
        //Fill your code here
        if(amount>10000){
            Console.WriteLine($"The Amount is transferred using RTGS Transfer\nRs.{amount} is transferred to the Account Number {accountNumber} successfully");

        }else{
            Console.WriteLine("RTGS Transfer can be done for the amount greater than Rs.10000");
        }

    }
}
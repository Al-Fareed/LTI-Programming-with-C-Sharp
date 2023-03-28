using System;
public abstract class FundTransfer
{

    public abstract void Transfer(string accountNumber, double amount);

    public static int Validate(string accountNumber, double amount)
    {
        //Fill your code here
        if (accountNumber.Length == 10 && amount > 0)
            return 1;
        else
            return 0;
    }
}
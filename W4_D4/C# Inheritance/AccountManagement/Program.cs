using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of accounts:");
        int n = int.Parse(Console.ReadLine());
        List<FixedAccount> fixedAccountList = new List<FixedAccount>();
        AccountBO accountBO=new AccountBO();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter account-{0} Detail:",(i+1));
            string input = Console.ReadLine();
            FixedAccount fixedAccount=accountBO.CreateAccountDetail(input);
            fixedAccountList.Add(fixedAccount);
        }
        accountBO.DisplayAccountDetails(fixedAccountList);
    }
}
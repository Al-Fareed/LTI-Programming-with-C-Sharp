using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program{
    static void Main(){
        Console.WriteLine("Enter the number of accounts:");
        int n = int.Parse(Console.ReadLine());
         List<FixedAccount> fixedAccountList = new List<FixedAccount>();
        AccountBO accountBO = new AccountBO();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter account-{i+1} Detail:");
            string input = Console.ReadLine();
            FixedAccount fixedAccount = accountBO.CreateAccountDetail(input);
            fixedAccountList.Add(fixedAccount);
        }
        accountBO.DisplayAccountDetails(fixedAccountList);
    }
}
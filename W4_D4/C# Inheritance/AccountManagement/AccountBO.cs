using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class AccountBO
{
    public FixedAccount CreateAccountDetail(String detail)
    {
        //fill code here
        string[] accountDetails = detail.Split(',');
        string accountNumber = accountDetails[0];
        double balance = double.Parse(accountDetails[1]);
        string accountHolderName = accountDetails[2];
        double minimumBalance = double.Parse(accountDetails[3]);
        int lockingPeriod = int.Parse(accountDetails[4]);

        Console.WriteLine(detail);
        FixedAccount fixedAccount=new FixedAccount(accountNumber, balance, accountHolderName, minimumBalance, lockingPeriod);
        return fixedAccount;
    }

    public void DisplayAccountDetails(List<FixedAccount> fixedAccountList) {
        Console.WriteLine("{0,-20} {1,-10} {2,-20} {3,-20} {4}","Account Number","Balance","Account holder name","Minimum balance","Locking period");
        //fill code here
        foreach (FixedAccount fixedAccount in fixedAccountList)
        {
            Console.WriteLine("{0,-20} {1,-10:F1} {2,-20} {3,-20:F1} {4}", fixedAccount.AccountNumber, fixedAccount.Balance, fixedAccount.AccountHolderName, fixedAccount.MinimumBalance, fixedAccount.lockingPeriod);
        }
    }
} 
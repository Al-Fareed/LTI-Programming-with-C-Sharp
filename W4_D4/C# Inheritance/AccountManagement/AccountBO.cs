class AccountBO
{
    public FixedAccount CreateAccountDetail(String detail){
        string[] details=detail.Split(",");
        string accountNumber=details[0];
        double balance=double.Parse(details[1]);
        string name=details[2];
        double minBal=double.Parse(details[3]);
        int lockPeriod=int.Parse(details[4]);
        FixedAccount fixedAccount = new FixedAccount(accountNumber,balance,name,minBal,lockPeriod);
        return fixedAccount;
    }
    public void DisplayAccountDetails(List<FixedAccount> fixedAccountList){
        Console.WriteLine("{0,-20} {1,-10} {2,-20} {3,-20} {4}","Account Number","Balance","Account holder name","Minimum balance","Locking period");
          foreach (FixedAccount fixedAccount in fixedAccountList)
        {
            Console.WriteLine("{0,-20} {1,-10:F1} {2,-20} {3,-20:F1} {4}",fixedAccount.AccountNumber,fixedAccount.Balance,fixedAccount.AccountHolderName,fixedAccount.MinimumBalance,fixedAccount.LockingPeriod);
        }
    }
}
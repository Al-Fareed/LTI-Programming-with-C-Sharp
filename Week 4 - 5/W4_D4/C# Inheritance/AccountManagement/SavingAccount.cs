class SavingAccount : Account
{
    private double _minimumBalance;
    public SavingAccount(string _accountNumber, double _balance, string _accountHolderName, double _minimumBalance) : base( _accountNumber,_balance,_accountHolderName)
    {
        this._minimumBalance=_minimumBalance;    
    }
    public double MinimumBalance{
        get=>this._minimumBalance;
    }
}
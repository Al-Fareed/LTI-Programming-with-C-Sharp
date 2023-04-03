class FixedAccount : SavingAccount
{
    private int	_lockingPeriod;
    public FixedAccount(string _accountNumber, double _balance, string _accountHolderName, double _minimumBalance, int _lockingPeriod) :
     base (_accountNumber,_balance,_accountHolderName,_minimumBalance)
    {
        this._lockingPeriod=_lockingPeriod;
    }
    public int LockingPeriod{get=>this._lockingPeriod;}
}
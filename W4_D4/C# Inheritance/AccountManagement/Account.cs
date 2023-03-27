class Account
{
    private string _accountNumber;
    private double _balance;
    private string _accountHolderName;
    public Account(string _accountNumber, double _balance, string _accountHolderName)
    {
        this._accountNumber=_accountNumber;
        this._balance=_balance;
        this._accountHolderName=_accountHolderName;
    }
    public string AccountNumber{
        get=>this._accountNumber;
    }
    public double Balance{
        get=>this._balance;
    }
    public string AccountHolderName{
        get=>this._accountHolderName;
    }
}
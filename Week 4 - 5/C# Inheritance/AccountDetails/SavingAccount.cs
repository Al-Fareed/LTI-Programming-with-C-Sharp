using System;
class SavingAccount : Account
{
    private double _interestRate;
    public SavingAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber, double _interestRate)
    {
        this._holderName = _holderName;
        this._accountNumber = _accountNumber;
        this._IFSCCode = _IFSCCode;
        this._contactNumber = _contactNumber;
        this._interestRate = _interestRate;
    }
    public double InterestRate{
        set=>_interestRate=value;
        get => _interestRate;
    }
    public override void Display()
    {
        Console.WriteLine("Your Contact Details\nHolderName : {0}\nAccount Number : {1}\nIFSCCode : {2}\nContactNumber : {3}\nInterest Rate : {4}", HolderName, AccountNumber, IFSCCode, ContactNumber,InterestRate);
    }

}


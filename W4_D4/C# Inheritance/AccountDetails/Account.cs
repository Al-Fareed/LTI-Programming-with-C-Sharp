using System;
class Account
{
    protected string _holderName;
    protected long _accountNumber;
    protected string _IFSCCode;
    protected long _contactNumber;

    public Account()
    {
        this._holderName = "";
        _accountNumber = 0;
        _IFSCCode = "";
        _contactNumber = 0;
    }
    public Account(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber)
    {
        this._holderName = _holderName;
        this._accountNumber = _accountNumber;
        this._IFSCCode = _IFSCCode;
        this._contactNumber = _contactNumber;
    }

    public string HolderName{
        set=>_holderName=value;
        get=>_holderName;
    }
    public long AccountNumber{
        set=>_accountNumber=value;
        get=>_accountNumber;
    }
    public string IFSCCode{
        set=>_IFSCCode=value;
        get=>_IFSCCode;
    }
    public long ContactNumber{
        set=>_contactNumber=value;
        get=>_contactNumber;
    }


    public virtual void Display()
    {
        Console.WriteLine("Your Contact Details\nHolderName :{0}\nAccount Number :{1}\nIFSCCode :{2}\nContactNumber :{3}",HolderName,AccountNumber,IFSCCode,ContactNumber);
    }
}

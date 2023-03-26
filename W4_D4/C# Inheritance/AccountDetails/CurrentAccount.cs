using System;
class CurrentAccount : Account
{
    private string _organizationName;
    private long _TIN;
    public CurrentAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber, string _organizationName, long _TIN)
    {
        this._holderName = _holderName;
        this._accountNumber = _accountNumber;
        this._IFSCCode = _IFSCCode;
        this._contactNumber = _contactNumber;
        this._organizationName=_organizationName;
        this._TIN=_TIN;
    }
    public string OrganizationName{
        get=>_organizationName;
        set=>_organizationName=value;
    }
    public long TIN{
        get=>_TIN;
        set=>_TIN=value;
    }
    public override void Display()
    {
        Console.WriteLine("Your Contact Details\nHolderName : {0}\nAccount Number : {1}\nIFSCCode : {2}\nContactNumber : {3}", HolderName, AccountNumber, IFSCCode, ContactNumber);
        Console.WriteLine("Organization Name : {0}\nTIN : {1}",OrganizationName,TIN);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Account
{
    private String _accountNumber;
    private Double _balance;
    private String _accountHolderName;

    //fill code here
    public Account(string _accountNumber, double _balance, string _accountHolderName)
    {
        this._accountNumber=_accountNumber;
        this._balance=_balance;
        this._accountHolderName=_accountHolderName;
    }
    public string AccountNumber{get;set;}
    public double Balance{get;set;}
    public String AccountHolderName{get;set;}

}
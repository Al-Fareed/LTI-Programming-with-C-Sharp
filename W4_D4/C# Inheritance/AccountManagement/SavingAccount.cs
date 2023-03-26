using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SavingAccount :Account
{
    private Double _minimumBalance;

    //fill code here
    public SavingAccount(string _accountNumber, double _balance, string _accountHolderName, double _minimumBalance): base(_accountNumber,  _balance, _accountHolderName)
    {
        
        this._minimumBalance=_minimumBalance;
    }
    public double MinimumBalance{get;set;}
}
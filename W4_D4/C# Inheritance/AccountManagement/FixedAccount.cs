using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FixedAccount:SavingAccount
{
    private int _lockingPeriod;

    //fill code here
    public FixedAccount(string _accountNumber, double _balance, string _accountHolderName, double _minimumBalance, int _lockingPeriod): base(_accountNumber,  _balance, _accountHolderName,_minimumBalance)
    {
        this._lockingPeriod=_lockingPeriod;
    }
    public int lockingPeriod{get;set;}
}
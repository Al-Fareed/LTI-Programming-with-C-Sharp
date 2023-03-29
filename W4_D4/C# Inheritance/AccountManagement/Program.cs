/*
Account, Savings account, Fixed account
[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create class  Account with following variables/ attributes.

Data type	Variable name
string	_accountNumber
double	_balance
string	_accountHolderName

Includes three argument constructor with a parameter in the following order
(string _accountNumber, double _balance, string _accountHolderName)

Create class SavingAccount which extends Account class with following variables/ attributes.

Data type	Variable name
double	_minimumBalance

Includes four-argument constructor with parameters in the following order
(string _accountNumber, double _balance, string _accountHolderName, double _minimumBalance)

Create class FixedAccount which extends SavingAccount class with following variables/ attributes.

Data type	Variable name
int	_lockingPeriod

Include a five argument constructor with parameters in the following order
(string _accountNumber, double _balance, string _accountHolderName, double _minimunBalance, int _lockingPeriod)

Create class AccountBO with following methods,

Method name	Method Description
public FixedAccount CreateAccountDetail(String detail)	This method is used to create a FixedAccount instance using the parameter detail which contains the account details in comma separated format.
public void DisplayAccountDetails(List<FixedAccount> fixedAccountList)	This method is used to display all the FixedAccount details in fixedAccountList 

Create Program class with the Main method, read the number of accounts and the account details.
Print all the account details along with the savings and fixed account details.
Console.WriteLine("{0,-20} {1,-10} {2,-20} {3,-20} {4}","Account Number","Balance","Account holder name","Minimum balance","Locking period");

Hint:
Print one decimal point for the double datatype.

The input format is:
_accountNumber,_balance,_accountHolderName,_minimumBalance,_lockingPeriod

Input and Output Format
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output:

Enter the number of accounts:
3
Enter account-1 Detail:
ACC001,5456.0,Tony Blake,500,10
Enter account-2 Detail:
ACC002,16558.0,Micheal John,500,6
Enter account-3 Detail:
ACC005,36784.0,Jason,500,14
Account Number       Balance    Account holder name  Minimum balance      Locking period
ACC001               5456.0     Tony Blake           500.0                10
ACC002               16558.0    Micheal John         500.0                6
ACC005               36784.0    Jason                500.0                14
*/

using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of accounts:");
        int n = int.Parse(Console.ReadLine());
        List<FixedAccount> fixedAccountList = new List<FixedAccount>();
        AccountBO accountBO=new AccountBO();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter account-{0} Detail:",(i+1));
            string input = Console.ReadLine();
            FixedAccount fixedAccount=accountBO.CreateAccountDetail(input);
            fixedAccountList.Add(fixedAccount);
        }
        accountBO.DisplayAccountDetails(fixedAccountList);
    }
}

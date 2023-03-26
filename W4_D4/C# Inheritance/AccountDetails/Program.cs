/*
Account Details
Write a program to read and display the various type of account details.
 
[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

 

Consider the class Account with the following private attributes/variables.

Data Type	Variable
string	_holderName
long	_accountNumber
string	_IFSCCode
long	_contactNumber
Include appropriate getters and setters.
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor Account(string _holderName,long _accountNumber,string _IFSCCode,long _contactNumber)


Define the following method in the Account class.

Method Name	Description
public void Display()	This method displays account details in the following order _holderName,_AccountNumber,_IFSCCode,_contactNumber.
Display the statement ‘Your Contact Details’ inside this method.
 


Consider the class SavingAccount which inherits Account class with the following private attributes/variables.

Data Type	Variable
double	_interestRate

Define the following method in the SavingAccount class.

Method Name	Description
public void Display()	This method is used to call the base class Display() and in addition displays _interestRate.
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor SavingAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber, double _interestRate)
Use base Keyword to call the base class constructor.


Consider the class CurrentAccount which inherits Account class with the following private attributes/variables.

Data Type	Variable
string	_organizationName
long	_TIN

Define the following method in the CurrentAccount class
Method Name	Description
 public void Display()	This method is used to call base class Display() and in addition displays _organizationName,_TIN
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor CurrentAccount(string _holderName, long _accountNumber, string _IFSCCode, long _contactNumber,string _organizationName, long _TIN)
Use base Keyword to call the base class constructor.


Create Program class with Main method, get user details in comma seperated format in the following order (HolderName,Account Number,IFSC code,Contact Number).
Display the Account Details by calling method of base class with child class object.


The link to download the template code is given below
Code Template

Input and Output Format:
Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]

 

Sample Input and Output 1:
Enter User Details(HolderName,Account Number,IFSC code,Contact Number)
Steffan,982714210,S160030600514,9092304676
Enter Account Type
saving
Enter Interest Rate
12.0
Your Contact Details
HolderName : Steffan
Account Number : 982714210
IFSCCode : S160030600514
ContactNumber : 9092304676
Interest Rate : 12
 

Sample Input and Output 2:
Enter User Details(HolderName,Account Number,IFSC code,Contact Number)
John,7889142075,S1600ABY0576,9944001700
Enter Account Type
current
Enter organization Name
pentamedia Graphics Limited
Enter TIN number
7841
Your Contact Details
HolderName : John
Account Number : 7889142075
IFSCCode : S1600ABY0576
ContactNumber : 9944001700
Organization Name : pentamedia Graphics Limited
TIN : 7841

Sample Input and Output 3:
Enter User Details(HolderName,Account Number,IFSC code,Contact Number)
Shira,987451024,SWQ78914AF,9078425168
Enter Account Type
curr
Enter valid Account Type
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        Account a = new Account();
        Console.WriteLine("Enter User Details(HolderName,Account Number,IFSC code,Contact Number)");
        string[] details = Console.ReadLine().Split(",");
        Console.WriteLine("Enter Account Type");
        string accountType = Console.ReadLine();

        string HolderName = details[0];
        long AccountNumber = long.Parse(details[1]);
        string IFSCCode = details[2];
        long ContactNumber = long.Parse(details[3]);

        int type = accountType == "saving" ? 1
                 : accountType == "current" ? 2
                 : 3;
        if (type == 1)
        {
            Console.WriteLine("Enter Interest Rate");
            double rate = double.Parse(Console.ReadLine());
            SavingAccount s = new SavingAccount(HolderName, AccountNumber, IFSCCode, ContactNumber, rate);
            s.Display();
        }
        else if (type == 2)
        {
            Console.WriteLine("Enter organization Name");
            string orgName = Console.ReadLine();
            Console.WriteLine("Enter TIN number");
            int tinNumber = int.Parse(Console.ReadLine());
            CurrentAccount c = new CurrentAccount(HolderName, AccountNumber, IFSCCode, ContactNumber, orgName, tinNumber);
            c.Display();
        }
        else
        {
            Console.WriteLine("Enter valid Account Type");
        }
    }
}


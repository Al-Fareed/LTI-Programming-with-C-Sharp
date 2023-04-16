/*
Money Transfer - Abstract Class
Write a program to transfer the money and display the details based on the transfer type.

[Note : Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider an abstract class FundTransfer with the following methods,

Method Name	Description
abstract void Transfer(string accountNumber, double amount)	This method is an abstract method to be implemented in all child classes.
static int Validate(string accountNo, double amount)	This method is used to validate the transaction on the following constraints.
If the accountNumber has 10 digit and the amount is greater than 0, then return 1. Otherwise return 0.

Consider the class NEFTTransfer which inherits FundTransfer class with following private attributes.

Data Type	Attribute
DateTime	_date
DateTime	_start
DateTime	_end

Note: Get the _date in hh:mm:ss tt format.
Assign _start as 09:00:00 AM
Assign _end as 06:00:00 PM

Define the following method in NEFTTransfer class.

Method Name	Description
void Transfer(string accountNumber, double amount)	Get the transaction time from user.
If the transaction time lies between 9.00 AM and 6.00 PM, then display the accountNumber and amount.
Otherwise display the transaction time and error message as in the sample output.


Consider the class IMPSTransfer which inherits FundTransfer class with the following method,
Method Name	Description
void Transfer(string accountNumber, double amount)	In this method, calculate and display the service charge of 2% of the transfer amount.


Consider the class RTGSTransfer which inherits FundTransfer class with the following method,
Method Name	Description
void Transfer(string accountNumber, double amount)	In this method,check whether the amount is greater than 10000. If the amount>10000, then display the accountNumber and amount.
Otherwise display the error message ‘RTGS Transfer can be done for the amount greater than Rs.10000’

Consider Program class with Main method to test the above classes.  
In the Main() method, get the values for accountNumber,amount and transfer type from the user.
Based on the transfer type, call the corresponding class methods and display the corresponding output.

The link to download the template code is given below
Code Template


Input and Output Format:

Display “Invalid Transfer Type” when user selects invalid type of transaction.

Display “Invalid data” when the given data is invalid.
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output 1:
Enter the Account number:
4586213687
Enter the amount to be transferred:
20000
Enter the type of transfer:
1.NEFT Transfer
2.IMPS Transfer
3.RTGS Transfer
1
Enter the Transaction time(hh:mm:ss tt):
10:45:25 AM
The Amount is transferred using NEFT Transfer
Rs.20000 is transferred to the Account Number 4586213687 successfully

Sample Input and Output 2:
Enter the Account number:
4586213687
Enter the amount to be transferred:
20000
Enter the type of transfer:
1.NEFT Transfer
2.IMPS Transfer
3.RTGS Transfer
1
Enter the Transaction time(hh:mm:ss tt):
08:45:25 AM
The Transaction Time is 08:45:25 AM
NEFT Transfer is applicable between 9.00 AM and 6.00 PM.
 
Sample Input and Output 3:
Enter the Account number:
5412369874
Enter the amount to be transferred:
20000
Enter the type of transfer:
1.NEFT Transfer
2.IMPS Transfer
3.RTGS Transfer
2
The Amount is transferred using IMPS Transfer
Rs.20000 is transferred to the Account Number 5412369874 successfully
The Service charge for this transaction is Rs.400

Sample Input and Output 4:
Enter the Account number:
4125896547
Enter the amount to be transferred:
20000
Enter the type of transfer:
1.NEFT Transfer
2.IMPS Transfer
3.RTGS Transfer
3
The Amount is transferred using RTGS Transfer
Rs.20000 is transferred to the Account Number 4125896547 successfully

Sample Input and Output 5:
Enter the Account number:
4125896547
Enter the amount to be transferred:
9000
Enter the type of transfer:
1.NEFT Transfer
2.IMPS Transfer
3.RTGS Transfer
3
RTGS Transfer can be done for the amount greater than Rs.10000
 
Sample Input and Output 6:
Enter the Account number:
8541247856
Enter the amount to be transferred:
20000
Enter the type of transfer:
1.NEFT Transfer
2.IMPS Transfer
3.RTGS Transfer
4
Invalid Transfer Type

Sample Input and Output 7:
Enter the Account number:
854124785
Enter the amount to be transferred:
20000
*/
using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Account number:");
        string accountNo = Console.ReadLine();
        Console.WriteLine("Enter the amount to be transferred:");
        double amount = Convert.ToDouble(Console.ReadLine());
        int result = FundTransfer.Validate(accountNo, amount);
        if (result == 1)
        {
            Console.WriteLine("Enter the type of transfer:\n1.NEFT Transfer\n2.IMPS Transfer\n3.RTGS Transfer");
            int type = Convert.ToInt32(Console.ReadLine());
            if (type == 1)
            {   
                NEFTTransfer nt = new NEFTTransfer();
                nt.Transfer(accountNo, amount);
            }
            else if (type == 2)
            {
                IMPSTransfer it = new IMPSTransfer();
                it.Transfer(accountNo, amount);
            }
            else if (type == 3)
            {
                RTGSTransfer rt = new RTGSTransfer();
                rt.Transfer(accountNo, amount);
            }
            else
            {
                Console.WriteLine("Invalid Transfer Type");
            }
        }
        else
            Console.WriteLine("Invalid data");
    }
}
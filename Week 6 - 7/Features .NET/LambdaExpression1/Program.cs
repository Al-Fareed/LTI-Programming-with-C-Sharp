/*
Lamda Expression 1
India is planning to repay the loan taken from the world bank,but Money is distributed among the people through loan.Hence they took survey,that survey says many citizens who took education loan feels difficult in paying that ,therfore indian government planned to give a discount to those who took education loan and get back the money soon and repay .Write a C# program to calculate the amount has to be paid by them after discounted.
Create a class named Account with following private data members
String aNumber
Double premium
int discountPercent
Create lambda expressions for to calculate the actual price which accepts the premium and discountPercent as attributes


Specification: Use Lambda expression.


Sample Input and Output:
Enter the number of accounts :
2
Enter accounts :
Account Number :
FTY38290
Premium :
5000
Discount Percent :
10
Account Number :
SDJF8347
Premium :
3000
Discount Percent :
15
Account Details :
Account : FTY38290
Premium : Rs.5000.0
Discount :10%
Amount to be paid : Rs.4500.0
Account : SDJF8347
Premium : Rs.3000.0
Discount :15%
Amount to be paid : Rs.2550.0
*/
using System;
using System.Collections.Generic;
class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of accounts :");
        int noOfAcc = int.Parse(Console.ReadLine());

        List<Account> accountList = new List<Account>();
        Console.WriteLine("Enter accounts :");
        for (int i = 0; i < noOfAcc; i++)
        {
            Console.WriteLine("Account Number :");
            string aNumber = Console.ReadLine();
            Console.WriteLine("Premium :");
            double premium = double.Parse(Console.ReadLine());
            Console.WriteLine("Discount Percent :");
            int percent = int.Parse(Console.ReadLine());
            
            accountList.Add(new Account(aNumber,premium,percent));
        }
        Console.WriteLine("Account Details :");
        foreach (Account account in accountList)
        {
            Console.WriteLine("Account : "+account.AccNo);
            Console.WriteLine("Premium : Rs."+string.Format("{0:0.0}",account.Premium));
            Console.WriteLine("Discount :{0}%",account.Discount);

            Func<double, int, double> calculateAmount = (premium, discountPercent) =>
            {
                double discountAmount = (premium * discountPercent) / 100;
                return premium - discountAmount;
            };

            double amount = calculateAmount(account.Premium,account.Discount);
            Console.WriteLine("Amount to be paid : Rs."+string.Format("{0:0.0}",amount));
        }
    }
}
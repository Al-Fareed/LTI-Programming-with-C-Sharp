/*
Exception Handling
Create Program class with Main method.
In the Main() method, get the details of the item type from the user and display the details.
Use try catch blocks to display an error message in case of exception.

Input and Output Format
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output 1 :
Enter the item type name
Catering
Enter the deposit
25000
Enter the cost per day
10k
Input string was not in the correct format

Sample Input and Output 2 :
Enter the item type name
Decoration
Enter the deposit
10000
Enter the cost per day
5000
Item type details
Name:Decoration
Deposit:10000
CostPerDay:5000
*/
using System;
class Program
{
    static void Main(string[] args){
        try
        {
            Console.WriteLine("Enter the item type name");
            string iName = Console.ReadLine();

            Console.WriteLine("Enter the deposit");
            int deposit = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the cost per day");
            int costPerDay = int.Parse(Console.ReadLine());

            Console.WriteLine("Item type details\nName:"+iName);
            Console.WriteLine("Deposit:"+deposit);
            Console.WriteLine("Cost per day:"+costPerDay);
        }
        catch (System.Exception)
        {
            Console.WriteLine("Input string was not in the correct format");
        }
    }
}
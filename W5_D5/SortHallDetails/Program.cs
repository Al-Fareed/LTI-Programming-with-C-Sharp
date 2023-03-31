/*
Sort Hall Details - IComparable Interface
Write a program to display the hall details in sorted order based on cost per day.
 
[Note: Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]
Consider a class Hall with the following private member variables/ attribute which extends IComparable interface.

Data Type	Attribute
string	_name
long	_mobileNumber
string	_ownerName
double	_costPerDay
The methods for constructors is given in the template code.
Override CompareTo Method in Hall class which compares the halls based on costPerDay of the halls.
Override ToString() method in the Hall class to display the hall details in the specified format. 

Consider Program class with Main method to test above class.


Note:

Consider the costPerDay of halls are unique.

Display the hall details in sorted order based on costPerDay.

 

The link to download the template code is given below
Code Template


Input and  Output Format :
Get Hall details in a comma separated format in the following order (name,mobileNumber,ownerName,costPerDay).

Use the below format to display hall details

string.Format("{0,-20} {1,-15} {2,-15} {3,-10}",_name,_mobileNumber,_ownerName,_costPerDay)

Refer sample input and output for formatting specifications. 

 

[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input And Output  1: 

Enter total number of halls
2
Enter Hall Details
royal orchid,9092304616,John,25000
Sodit Banquet,9381415278,peter,14000
Hall Name           MobileNumber      OwnerName      CostPerDay
Sodit Banquet        9381415278      peter           14000
royal orchid         9092304616      John            25000
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        List<Hall> hallList = new List<Hall>();

        Console.WriteLine("Enter total number of halls");
        int ch = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter Hall Details");
        string hallDetails ;
        //Fill your code here
        for (int i = 0; i < ch; i++)
        {
            hallDetails=Console.ReadLine();
            string[] item = hallDetails.Split(",");
            Hall hall = new Hall(item[0], long.Parse(item[1]), item[2], double.Parse(item[3]));
            hallList.Add(hall);
        }
        
        hallList.Sort();
        Console.WriteLine("{0,-20} {1,-15} {2,-15} {3,-10}","Hall Name","MobileNumber","OwnerName","CostPerDay");
        foreach (Hall hall in hallList)
        {
            Console.WriteLine(hall.ToString());
        }
    }

}

/*
Basic Interface
Write a program to read and display the stall details using display method in stall interface.

 

[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create an interface IStall with the following abstract method.

Method	Description
void display()	Display the Stall details

Consider a class named GoldStall with the following private attributes which implements the IStall interface.

Data Type	Attributes
string	_name
string	_details
double	_cost
string	_ownerName
The methods for getters, setters and constructors are given in the template code.
Implement the abstract method of IStall in the class GoldStall which should display the details of the stall. 
Assign the GoldStall reference to the IStall reference and call display method using interface reference.


Consider a class named ExecutiveStall with the following private attributes which implements the IStall interface.

Data Type	Attributes
string	_name
string	_details
double	_cost
string	_ownerName
int	_numberOfTVSet
The methods for getters, setters and constructors are given in the template code.
Implement the abstract method of IStall in the class ExecutiveStall which should display the details of the stall.
Assign the ExecutiveStall reference to the IStall reference and call display method using interface reference.


Consider a class named PremiumStall with the following private attributes which implements the IStall interface.

Data Type	Attributes
string	_name
string	_details
double	_cost
string	_ownerName
int	_numberOfProjector
The methods for getters, setters and constructors are given in the template code.
Implement the abstract method of IStall in the class PremiumStall which should display the details of the stall.
Assign the PremiumStall reference to the IStall reference and call display method using interface reference.


Consider class Program with Main method to get the details of the stall from the user and display the details using the Display() method of the respective class. Display “Invalid Input” when user gives invalid choice of stall.

The link to download the template code is given below
Code Template


Input and Output Format:

The cost of the stall should be displayed upto 2 decimal palces.
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output 1 :
Stall Type:
1.Gold Stall
2.Executive Stall
3.Premium Stall
1
Enter the stall name
Furniture
Enter the details
Sofa comforts
Enter the cost
10000
Enter the owner name
John
Stall name:Furniture
Details:Sofa comforts
Cost:10000.00
Owner:John

Sample Input and Output 2 :
Stall Type:
1.Gold Stall
2.Executive Stall
3.Premium Stall
2
Enter the stall name
Pasteries and Eateries
Enter the details
Food
Enter the cost
15000
Enter the owner name
Albert
Enter the number of TV set
3
Stall name:Pasteries and Eateries
Details:Food
Cost:15000.00
Owner:Albert
Number of TV set:3

Sample Input and Output 3 :

Stall Type:
1.Gold Stall
2.Executive Stall
3.Premium Stall
3
Enter the stall name
Natural
Enter the details
Herbal Products
Enter the cost
25000
Enter the owner name
Cassandra
Enter the number of projector
2
Stall name:Natural
Details:Herbal Products
Cost:25000.00
Owner:Cassandra
Number of projector:2


Sample Input and Output 4 :
Stall Type:
1.Gold Stall
2.Executive Stall
3.Premium Stall
5
Invalid Input

 
*/
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Stall Type:");
        Console.WriteLine("1.Gold Stall\n2.Executive Stall\n3.Premium Stall");
        int choice = Convert.ToInt32(Console.ReadLine());
        if (choice > 0 && choice < 4)
        {
            Console.WriteLine("Enter the stall name");
            string stallName = Console.ReadLine();
            Console.WriteLine("Enter the details");
            string details = Console.ReadLine();
            Console.WriteLine("Enter the cost");
            int cost = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the owner name");
            string ownerName = Console.ReadLine();
            if (choice == 1)
            {
                //Fill your code here
                IStall i = new GoldStall(stallName, details, cost, ownerName);
                i.display();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter the number of TV set");
                int numberOfTVSet = Convert.ToInt32(Console.ReadLine());
                //Fill your code here
                IStall i = new ExecutiveStall(stallName, details, cost, ownerName, numberOfTVSet);
                i.display();
            }
            else
            {
                Console.WriteLine("Enter the number of projector");
                int numberOfProjector = Convert.ToInt32(Console.ReadLine());
                //Fill your code here
                IStall i = new PremiumStall(stallName, details, cost, ownerName, numberOfProjector);
                i.display();
            }
        }
        else
        {
            //Fill your code here
            Console.WriteLine("Invalid Input");
        }

    }
}
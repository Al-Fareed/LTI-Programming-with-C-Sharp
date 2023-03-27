/*
Overloading

Write a program to calculate the cost of the stall based on its type. If the stall type is Gold, the cost will be Rs.100 per square feet. If the stall type is Diamond, the cost will be Rs.150 per square feet and cost of a TV will be Rs.100. If the stall type is Platinum, the cost will be Rs.200 per square feet and if they are using projector it will cost Rs.1000.

The 3 stall types are,

Gold
Diamond
Platinum
[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class named Stall and create the following methods.
Note: Use Overloading concept to define the ComputeCost method.

Method Name	Method Argument Type	Description
ComputeCost	string, int	The order of the parameters are stallType, squareFeet. This method is used to calculate the cost of the Gold stall on cost of Rs.100 per square feet.
ComputeCost	string, int, int	The order of the parameters are stallType, squareFeet, numberOfTV. This method is used to calculate the cost of the Diamond stall on cost of Rs.150 per square feet and cost per TV of Rs.100.
ComputeCost	string, int, bool	The order of the parameters are stallType, squareFeet, projectorAvailability. This method is used to calculate the cost of the Platinum stall on cost of Rs.200 per square feet and if they are using projector it costs Rs.1000.

Consider the class Program and write a Main method to test the above class.

In Main method, get the stall type and its corresponding stall details from the user and calculate the cost.

The link to download the template code is given below
Code Template


Input and Output Format :
Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input and Output 1 :

Enter the stall type
Gold
Enter the square feet
100
Gold costs Rs.10000

Sample Input and Output 2 :

Enter the stall type
Diamond
Enter the square feet
200
Enter the number of TV
1
Diamond costs Rs.30100

Sample Input and Output 3 :

Enter the stall type
Platinum
Enter the square feet
150
Do you need a projector(yes/no)
yes
Platinum costs Rs.31000
*/
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter the stall type");
        string stallType = Console.ReadLine();
        Console.WriteLine("Enter the square feet");
        int squareFeet = int.Parse(Console.ReadLine());
        //fill code here
        if (stallType == "Gold")
        {
            new Stall().ComputeCost(stallType, squareFeet);
        }
        else if (stallType == "Platinum")
        {
            Console.WriteLine("Do you need a projector(yes/no)");
            string ch = Console.ReadLine();
            bool b = ch == "yes" ? true : false;
            new Stall().ComputeCost(stallType, squareFeet, b);
        }
        else
        {
            Console.WriteLine("Enter the number of TV");
            int numberOfTV = int.Parse(Console.ReadLine());
            new Stall().ComputeCost(stallType,squareFeet,numberOfTV);
        }
    }
}
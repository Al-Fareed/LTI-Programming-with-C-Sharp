/*
Event Management
[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]


Create a class Event with the following private variables/ attributes.

Data type	Variable name
string	_name
string	_type
Include appropriate properties.

Includes a parameterized constructor with a parameter in the following order

public Event (string _name, string _type)

In the Event class include the following method

Method	Description
public virtual double ProjectedRevenue()	Returns 0.0

Create a class Exhibition which extends Event class with following variables/ attributes.

Data type	Variable name
int	_noOfStall
Include appropriate properties.

Include a parameterized constructor in the following order (string _name, string _type, int _noOfStall).

In Exhibition class override the ProjectedRevenue() method

Method 	Description
public double ProjectedRevenue()	This method is used to calculate the total revenue from the exhibition and return the revenue amount.
 


Create class StageEvent which extends Event class with following variables/ attributes.

Data type	Variable name
int	_noOfShows
int	_noOfSeats

Include parameterized constructor in the following order (string _name, string _type, int _noOfSeats, int _noOfShows).

In StageEvent class override the ProjectedRevenue() method

Method name	Method description
public double ProjectedRevenue()	This method is used to calculate the total revenue from stage events and return the revenue amount.

Create a class Program with the Main method to test the above classes.
Note: For Exhibition, each stall will produce Rs.10000 as revenue. For StageEvent, each seat produces Rs.50 revenue.

Input and Output Format:
Refer sample input and output for formatting specifications. Display the total revenue amount correct to 1 decimal place.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output 1:

1. Exhibition
2. Stage Event
Enter the choice:
1
Enter the event name:
Planetarium
Enter the number of stalls:
34
Event name:Planetarium
Event type:Exhibition
Total revenue amount : 340000.0

Sample Input and Output 2:
1. Exhibition
2. Stage Event
Enter the choice:
2
Enter the event name:
Magic Show
Enter the number of seats:
350
Enter the number of shows:
7
Event name:Magic Show
Event type:Stage Event
Total revenue amount : 122500.0
 
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
        Console.WriteLine("1. Exhibition\n2. Stage Event\nEnter the choice:");
        int ch = int.Parse(Console.ReadLine());
        //fill code here
        string name;
        Console.WriteLine("Enter the event name:");
        name = Console.ReadLine();
        //fill code here
        string type;
        Event eve = null;
        switch(ch) 
        {
            case 1:
                type="Exhibition";
                Console.WriteLine("Enter the number of stalls:");
                int noOfStall = int.Parse(Console.ReadLine());
                //fill code here
                Exhibition e=new Exhibition(name,type,noOfStall);
                Console.WriteLine($"Event name:{name}\nEvent type:{type}");
                Console.WriteLine("Total revenue amount : "+string.Format("{0:0.0}",e.ProjectedRevenue()));
                break;
            case 2:
                type="Stage Event";
                Console.WriteLine("Enter the number of seats:");
                int noOfSeats = int.Parse(Console.ReadLine());
                //fill code here
                Console.WriteLine("Enter the number of shows:");
                int noOfShows = int.Parse(Console.ReadLine());
                //fill code here
                StageEvent s = new StageEvent(name,type,noOfSeats,noOfShows);
                Console.WriteLine($"Event name:{name}\nEvent type:{type}");
                Console.WriteLine("Total revenue amount : "+string.Format("{0:0.0}",s.ProjectedRevenue()));
                break;
        }
        //fill code here
    }
}
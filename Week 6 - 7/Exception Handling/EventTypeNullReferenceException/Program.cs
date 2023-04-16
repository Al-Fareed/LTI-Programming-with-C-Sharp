/*
Event Type-Null Reference Exception
[Note :
Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create a class Event with following private attributes/variables.
Data Type	Variable
string	_name
string	_type
string	_organizer

Include appropriate Properties.
Include a three-argument constructor with parameters in the following order,
public Event(string _name, string _type, string _organizer)

In the Event class include the following method,
Method	Description
public void Display()	In this method, display the event name,event organizer
and event type.

Create class Exhibition which inherits Event class, with the following private attribute.
Data Type	Variable
int	_noOfStalls

Include appropriate Properties.
Include a four-argument constructor with parameters in the following order,
public Exhibition(string _name, string _type, string _organizer, int _noOfStalls)

Use base() method to assign the values of base class constructor.

In the Exhibition class include the following method,

Method	Description
public void Display()	Override the Display() method of Event class. In this method, call the
base class method to display the values of event name, event organizer and event type along with number of stalls.
    
Create Program class with Main method, read the event details from the user.
If the event type is Exhibition, then assign the values using the Exhibition class constructor.
If the event type is Others, then assign the value using Event class constructor.
Display the values using Display() of Exhibition class.
Use try and catch blocks to handle the Null Reference Exception and print the error message.


Input and Output Format
Refer sample Input and output for formatting specifications.  
All text in bold corresponds to input and rest corresponds to output.

Sample Input and Output 1
Enter the Event Name:
Rio Carnival
Enter the Event Organizer:
Andrea
Enter the Event Type(Exhibition/Others):
Exhibition
Enter No.of Stalls:
100
Event Name: Rio Carnival
Event organizer: Andrea
Event Type: Exhibition
No of Stalls: 100

Sample Input and Output 2
Enter the Event Name:
Cannes film festival
Enter the Event Organizer:
Daniel
Enter the Event Type(Exhibition/Others):
Others
Null Reference Exception... Event Type is not Exhibition
Event Name: Cannes film festival
Event organizer: Daniel
Event Type: Others

Sample Input and Output 3
Enter the Event Name:
Rio Carnival
Enter the Event Organizer:
Isabella
Enter the Event Type(Exhibition/Others):
Stage Event
Invalid event type...

*/
using System;
class Program
{
    static void Main(string[] args)
    {
        Event events = new Event();
        try
        {
            Console.WriteLine("Enter the Event Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Event Organizer:");
            string organizer = Console.ReadLine();
            Console.WriteLine("Enter the Event Type(Exhibition/Others):");
            string type = Console.ReadLine();
            if (type.Equals("Exhibition"))
            {
                Console.WriteLine("Enter No.of Stalls:");
                int noOfStalls = int.Parse(Console.ReadLine());


                Exhibition exhibition = new Exhibition(name, type, organizer, noOfStalls);
                exhibition.Display();
            }
            else if (type.Equals("Others"))
            {
                events = new Event(name, type, organizer);
                throw new NullReferenceException("Event Type is not Exhibition");

            }
            else
            {
                Console.WriteLine("Invalid event type...");
                return;
            }
        }
        catch (NullReferenceException e)
        {
            Console.WriteLine("Null Reference Exception... " + e.Message);
            events.Display();
        }
    }
}


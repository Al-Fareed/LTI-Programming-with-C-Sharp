/*
Display Event Details
The event details we have got are in a comma-separated format. But suddenly there is a need for the details in a different format. So get details in csv format and change comma into '|'. 

Write a program to get event details separated by a comma and change it into a format in which the details are separated by Pipe.

[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Event with the following private attributes

Data type	Attributes
string	_eventName
string	_organiserName
double	_eventCost
The methods for getters, setters and constructors are given in the template code.
Override ToString() method in the Event class to return the event details in the specified format.

Define the following public methods in the Event class,

Method Name	Description
void Display(List<Event> eventList)	This method takes event list as parameter and iterates over the list using Lambda Expression and displays the event details.
Display the statement ‘List of events’ inside this method.

Consider the class Program. It includes the method Main.
In the Main method,

read the event details from the user, display the list of events using lambda expression.
 

The link to download the template code is given below
Code Template


Input Format :

The first line of input corresponds to the number of events 'n'.
The next 'n' line of inputs corresponds to the event details in the CSV format of (Event Name,Organiser Name,Event Cost).

Output Format :

The output consists of event details separated by "|".
Refer sample input and output for formatting specifications.

[All text in bold corresponds to input and rest corresponds to output]

Sample Input and Output 1:

Enter the number of events
3
Enter event details in CSV(Event Name,Organiser Name,Event Cost)
Hip Hop,Wright Brothers,300000
Jaqulos,Einstein,1230000
Birthday,Joe,120000
List of events
Hip Hop|Wright Brothers|300000
Jaqulos|Einstein|1230000
Birthday|Joe|120000

 
*/
using System;
using System.Collections.Generic;
public delegate void displayDetails(List<Event> eventList);
class Program
{
    static void Main(string[] args){
        List<Event> events = new List<Event>();

        Console.WriteLine("Enter the number of events");
        int noOfEvents = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter event details in CSV(Event Name,Organiser Name,Event Cost)");
        for (int i = 0; i < noOfEvents; i++)
        {
            string[] eventDetails = Console.ReadLine().Split(",");
            events.Add(new Event(eventDetails[0],eventDetails[1],double.Parse(eventDetails[2])));
        }
        Event e = new Event();
        displayDetails dd = (eventList) =>{
            e.Display(eventList);
        };
        dd.Invoke(events);
    }
}
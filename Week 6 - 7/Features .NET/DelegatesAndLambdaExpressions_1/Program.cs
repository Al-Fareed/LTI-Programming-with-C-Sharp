/*
Delegates And Lambda Expressions - 1
Create class Event with the following private member variables/attributes.
Data Type	Variable Name
string	_name
string	_type
string	_organizer

Include appropriate properties.
Include a three argument constructor with parameters in the following order,
public Event(string _name, string _type, string _organizer)

Override ToString() method to display output in the specified format.
string.Format("{0,-15}{1,-15}{2,-15}", _name, _type, _organizer)

Create Program class with Main method, get the number of events and Event Details from the user as a comma-separated string in the following order (name,type, organizer).
Create a delegate method named EventDelegate(List<Event>) with void as the return type in Program class.
Store event details in a list. 
Create lambda expression(statement Lambda) to iterate through EventList.
Call the statement Lambda using delegate to print Event Details


Input and Output Format :
Refer sample input and output for formatting specifications. 
All text in bold corresponds to input and rest corresponds to output. 


Sample Input And Output 1:
Enter total number of events
3
Enter event details
Kurukshetra,Technical Fest,John
ozmenta,symposium,Sanchez
kratos,Stage Show,Hazard
EventName      EventType      EventOrganizer
Kurukshetra    Technical Fest John
ozmenta        symposium      Sanchez
kratos         Stage Show     Hazard
*/
using System;
using System.Collections.Generic;
public delegate void EventDelegate(List<Event> events);
class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        Console.WriteLine("Enter total number of events");
        int noOfEvents = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter event details");
        for (int i = 0; i < noOfEvents; i++)
        {
            string[] eventDetails = Console.ReadLine().Split(",");
            events.Add(new Event(eventDetails[0],eventDetails[1],eventDetails[2]));
        }
        Event e = new Event();
        EventDelegate ed=(eventList)=>{
            e.Display(eventList);
        };
        ed.Invoke(events);
    }
}
/*Event Organizer
Write a program to read the event details from the file and search the event details for particular organizer.
Create class Event with the following private attributes/variables.
Data Type	Variable
string	_name
string	_type
double	_cost
string	_organizer
Include appropriate properties.
Include a four argument constructor with parameters in the following order,
public Event(string _name, string _type, double _cost, string _organizer)

Override ToString() method to display the event details as in the sample output.

Create class EventBO with the following methods.

Method	Description
public List<Event> AddEvent(string details, List<Event> eventList)	In this method, load the event details into event object. Store the event object in the list and return the list
public void EventDisplay(string organizer, List<Event> list)	This method is used to get the details of the events organized by the given organizer.
 
Create Program class with Main() method, get the organizer name from user to diplay the event details organized by that organizer.
Read the input file using StreamReader.
Read the lines from the input file and create event object by parsing the input. Add all the event object to the List.
If the organizer name is found, display the details of event organized by the organizer. Else display "No events found for this organizer".

Note: The input.txt file consists of event name, event type, event cost and event organizer details is stored as fixed length format as follows,
Variable	Start Index	Length
name	0	25
type	25	15
cost	39	10
organizer	49	10

Input and Output Format
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output 1
Enter the organizer name to view:
Andrea
Events Organized by Andrea:
Event Name: Sky Lantern Festival
Event Type: Stage Event
Event Cost: 60000
Event Name: Stars of the white house
Event Type: Stage Event
Event Cost: 80000

Sample Input and Output 2
Enter the organizer name to view:
Sarah
Events Organized by Sarah:
No Event is found for this organizer...*/
using System;
using System.Collections.Generic;
using System.IO;
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            List<Event> events = new List<Event>();
            Console.WriteLine("Enter the organizer name to view:");
            string orgName = Console.ReadLine();
            StreamReader reader = new StreamReader("input.txt");
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string name = line.Substring(0, 25).Trim();
                string type = line.Substring(25, 15).Trim();
                double cost = double.Parse(line.Substring(39, 10));
                string organizer = line.Substring(49, 10).Trim();
                Event e = new Event(name, type, cost, organizer);
                events.Add(e);
            }
            new EventBO().EventDisplay(orgName, events);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
/*
Write File
Write a program to read the event details from the user and write it into a file in csv format.

Create class Event with the following private attributes/variables.
Data Type	Variable
string	_name
string	_type
double	_cost
string	_organizer

Include appropriate properties.
Include a four-argument constructor with parameters in the following order,
public Event(string name, string type, double cost, string organizer)

Create class EventBO with the following methods.
Method	Description
public void WriteEvents(List<Event> list)	This method is used to write output into a file named "output.csv". This output file contains unique event objects.
 
Create Program class Main method, get the event details as a comma separated values from the user in the following format.
(name,type,cost,organizer)
Write the unique event details into the  output file in csv format using StreamWriter Class.
Display a message stating that the output is written in a file.

Note: The Output file should be in the csv format as follows.
(name,type,cost,organizer)

Input and Output Format
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output 1
Enter the number of user
3
Enter the user details
Sky Lantern Festival,Stage Event,60000,Andrea
Rio Carnival,Exhibition,50000,Sachi
Songkran,Exhibition,75000,Sanna
Event Details is written in the file

The output.csv file should be as follows,
Sky Lantern Festival,Stage Event,60000,Andrea
Rio Carnival,Exhibition,50000,Sachi
Songkran,Exhibition,75000,Sanna

Sample Input and Output 2
Enter the number of user
3
Enter the user details
Stars of the white house,Stage Event,80000,Andrea
Stars of the white house,Stage Event,80000,Andrea
Cannes film festival,Stage Event,55000,Santana
Event Details is written in the file

The output.csv file should be as follows,
Stars of the white house,Stage Event,80000,Andrea
Cannes film festival,Stage Event,55000,Santana
*/
using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args){
        try
        {
            List<Event> eventList = new List<Event>();
            Console.WriteLine("Enter the number of events");
            int noOfUsers = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the event details");
            for (int i = 0; i < noOfUsers; i++)
            {
                string[] input = Console.ReadLine().Split(",");
                double cost = double.Parse(input[2]);
                eventList.Add(new Event(input[0],input[1],cost,input[3]));
            }
            new EventBO().WriteEvents(eventList);

        }
        catch (System.Exception)
        {
            
        }
    }
}
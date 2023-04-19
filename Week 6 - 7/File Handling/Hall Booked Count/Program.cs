/*

Hall Booked Count
[Note :
Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create class Event with the following private variables/attributes.
Data Type	Variable
string	_name
string	_detail
string	_type
string	_organizer
HallBooking	_hallBooking

Include appropriate properties.
Include a default constructor and a five argument constructor with parameters in the following order _name,  _hallBooking, _detail,  _type,  _organizer.

Pre-populate the following event details into a list.
Name	Detail	Type	Organizer
SARC Conference	International  Conference	Conference	Peter
Birthday party	Albert's Birthday party	Birthday	Daniel
Christmas Eve	Christmas celebration	Stage show	John
New Year Eve	New Year celebration	Stage show	Smith
Positive Psychology in Practice	International Conference	Conference	Merida

Create class Hall with the following private attributes/variables.
Data Type	Variable
string	_name
long	_mobileNumber
double	_costPerDay
string	_owner

Include appropriate properties.
Include a default constructor and a four argument constructor with parameters in the following order _name,  _mobileNumber, _costPerDay,  _owner.

Pre-populate the following hall details and store it into a list.
Name	Mobile number	Cost per day	Owner
The Great Hall	9874563210    	1000.00	Daniel
The Royal Hall	9865321470    	1500.00	Cassandra
The Gibson Hall	8796543211    	750.00	Abraham
Queen's Hall	8745693221    	5000.00	William

Create class HallBooking with the following private variables/attributes.
Data Type	Variable
Hall        	_hallInstance
Event        	_eventInstance
DateTime    	_startDate
DateTime    	_endDate
double        	_price

Include appropriate properties.
Include a default constructor and a five argument constructor with parameters in the following order _hallInstance,  _eventInstance, _startDate,  _endDate, _price.

Create class HallBookingBO with the following methods.
Method	
Description
public HallBooking CreateHallBooking(string value)	In this method, create HallBooking object with value and return it.
public Dictionary<string, int> HallBookedCount(List<HallBooking> list)	This method is used to get the count of events in each hall.

Create Program class with Main method to test above classes.
Read the input file using StreamReader.
Read the lines from the input file and create hallbooking object by parsing the input. Add all the hallbooking object to the List.
Display all the hall name and its event count.

Input Format:
The input file name must be "input.txt".
The input file consists of a set of HallBooking details in comma separated format in the order event name, hall name, start date, end date, price.

Output Format:
String.Format("{0,-20} {1,-10}", "Hall name", "Event count") 

Sample Output :
Hall details
Hall name            Event count
The Gibson Hall      1
The Great Hall       2
The Royal Hall       1
Queen's Hall         1
*/
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<HallBooking> hallBookingList = new List<HallBooking>();
        HallBookingBO hallBookingBO = new HallBookingBO();

        // Reading input file and creating hallbooking objects
        using (StreamReader sr = new StreamReader("input.txt"))
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                HallBooking hallBooking = hallBookingBO.CreateHallBooking(line);
                hallBookingList.Add(hallBooking);
            }
        }

        // Getting count of events in each hall
        Dictionary<string, int> hallBookingCount = hallBookingBO.HallBookedCount(hallBookingList);

        // Displaying hall name and event count
        Console.WriteLine("Hall details");
        Console.WriteLine("{0,-20} {1,-10}", "Hall name", "Event count");
        foreach (KeyValuePair<string, int> entry in hallBookingCount)
        {
            Console.WriteLine("{0,-20} {1,-10}", entry.Key, entry.Value);
        }
    }
}
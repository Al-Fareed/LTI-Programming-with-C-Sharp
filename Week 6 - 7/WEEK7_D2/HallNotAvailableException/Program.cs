/*

HallNotAvailableException
[Note :
Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create class Event with the following private variables/attributes.
Data Type	Variable
string	_name
string	_detail
string	_type
string	_organizer

Include appropriate properties.
Include default constructor and a four argument constructor with parameters in the following order: _name, _detail,  _type,  _organizer.

Create class Hall with the following private attributes/variables.
Data Type	Variable
string 	_name
long	_mobileNumber
double	_costPerDay
string	_owner

Include appropriate properties.
Include default constructor and a four argument constructor with parameters in the following order: _name,  _mobileNumber, _costPerDay,  _owner.

Create class HallBooking with the following private variables/attributes.
Data Type	Variable
Hall	_hallInstance
Event	_eventInstance
DateTime	_startDate
DateTime	_endDate
double	_price

Include appropriate properties.
Include default constructor and a five argument constructor with parameters in the following order _eventInstance, _hallInstance, _startDate,  _endDate, _price.

Create class HallBookingBO with the following method.
Method	Description
public bool ValidateHallBooking(List<HallBooking> bookings, HallBooking hallBooking)	In this method, check the availablity of the hall and return true if available, else throw HallNotAvailableException exception.

Create class HallNotAvailableException which extends Exception class.
Include a Constructor with an argument "Message" pass the message to the base class constructor.

Create Program class with Main method.
Pre-populate the following hall details and store it into a list
Name	Mobile number	Cost per day	Owner
Great Hall	9874563210	1000.00	Daniel
Royal Hall	9865321470	1500.00	Cassandra
Gibson Hall	8796543211	750.00	Abraham
Queen Hall	8745693221	5000.00	William

Pre-populate the following event details and store it into a list
Name	Detail	Type	Organizer
SARC Conference	International Conference	Conference	Peter
Birthday party	Albert's Birthday party	Birthday	Daniel
Christmas Eve	Christmas celebration	Stage show	John
New Year Eve	New Year celebration	Stage show	Smith

Create Program class with Main method, display the pre-populated event and hall details in the specified format
String.Format("{0} {1,-15} {2,-28} {3,-20} {4,-5}", "S.No","Name", "Detail", "Type", "Organizer")
String.Format("{0} {1,-10} {2,15} {3,15} {4,15}", "S.No", "Name", "Mobile number", "Cost per day", "Owner")

Get the hall booking details from the user.
Validate the availability of the hall and book it.
Use try catch block to catch the exception and display the error message. 

 
Input and Output Format
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output :
Event Details
S.No Name            Detail                       Type                 Organizer
1 SARC Conference International Conference     Conference           Peter
2 Birthday party  Albert's Birthday party      Birthday             Daniel
3 Christmas Eve   Christmas celebration        Stage show           John
4 New Year Eve    New Year celebration         Stage show           Smith
Hall Details
S.No Name         Mobile number    Cost per day           Owner
1 Great Hall      9874563210            1000          Daniel
2 Royal Hall      9865321470            1500       Cassandra
3 Gibson Hall      8796543211             750         Abraham
4 Queen Hall      8745693221            5000         William
Enter the hall id
1
Enter the event id
1
Enter the start date
12/12/2018
Enter the end date
01/01/2019
Enter the price
5400.00
Booked Successfully
Do you want to book a hall?(yes/no)
yes
Enter the hall id
1
Enter the event id
2
Enter the start date
12/12/2018
Enter the end date
01/01/2019
Enter the price
8795.00
Hall Not Available Exception
Do you want to book a hall?(yes/no)
no
*/
using System;
using System.Collections.Generic;

namespace HallBookingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pre-populated hall and event details
            List<Hall> halls = new List<Hall>
            {
                new Hall("Great Hall", 9874563210, 1000.00, "Daniel"),
                new Hall("Royal Hall", 9865321470, 1500.00, "Cassandra"),
                new Hall("Gibson Hall", 8796543211, 750.00, "Abraham"),
                new Hall("Queen Hall", 8745693221, 5000.00, "William")
            };

            List<Event> events = new List<Event>
            {
                new Event("SARC Conference", "International Conference", "Conference", "Peter"),
                new Event("Birthday party", "Albert's Birthday party", "Birthday", "Daniel"),
                new Event("Christmas Eve", "Christmas celebration", "Stage show", "John"),
                new Event("New Year Eve", "New Year celebration", "Stage show", "Smith")
            };

            // Display hall and event details
            Console.WriteLine("Event Details");
            Console.WriteLine(String.Format("{0} {1,-15} {2,-28} {3,-20} {4,-5}", "S.No", "Name", "Detail", "Type", "Organizer"));
            for (int i = 0; i < events.Count; i++)
            {
                Console.WriteLine(String.Format("{0} {1,-15} {2,-28} {3,-20} {4,-5}", i + 1, events[i].Name, events[i].Detail, events[i].Type, events[i].Organizer));
            }
            Console.WriteLine("Hall Details");
            Console.WriteLine(String.Format("{0} {1,-10} {2,15} {3,15} {4,15}", "S.No", "Name", "Mobile number", "Cost per day", "Owner"));
            for (int i = 0; i < halls.Count; i++)
            {
                Console.WriteLine(String.Format("{0} {1,-10} {2,15} {3,15} {4,15}", i + 1, halls[i].Name, halls[i].MobileNumber, halls[i].CostPerDay, halls[i].Owner));
            }

            string input = "yes";
            while (input.ToLower() == "yes")
            {
                Console.WriteLine("Enter the hall id");
                int hallId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the event id");
                int eventId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the start date");
                DateTime startDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter the end date");
                DateTime endDate = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Enter the price");
                double price = Convert.ToDouble(Console.ReadLine());

                try
                {
                    // Create hall booking instance and validate availability
                    HallBooking hallBooking = new HallBooking(events[eventId - 1], halls[hallId - 1], startDate, endDate, price);
                    bool isAvailable = HallBookingBO.ValidateHallBooking(new List<HallBooking>(), hallBooking);
                    if (!isAvailable)
                    {
                        throw new HallNotAvailableException("Hall Not Available Exception");
                    }
                    else
                    {
                        Console.WriteLine("Booked Successfully");
                    }
                }
                catch (HallNotAvailableException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Do you want to book a hall?(yes/no)");
                input = Console.ReadLine();
            }
        }
    }
}

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

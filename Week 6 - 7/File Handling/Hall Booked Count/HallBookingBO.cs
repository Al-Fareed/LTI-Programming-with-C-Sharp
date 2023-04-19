using System;
using System.Collections.Generic;

class HallBookingBO
{
    public HallBooking CreateHallBooking(string value)
    {
        string[] input = value.Split(',');
        string eventName = input[0].Trim();
        string hallName = input[1].Trim();
        DateTime startDate = DateTime.ParseExact(input[2], "dd/MM/yyyy", null);
        DateTime endDate = DateTime.ParseExact(input[3], "dd/MM/yyyy", null);
        double price = double.Parse(input[4]);
        Hall hall = Hall.GetAllHalls().Find(h => h.Name == hallName);
        Event _event = Event.GetAllEvents().Find(e => e.Name == eventName);

    HallBooking hallBooking = new HallBooking(_event,hall, startDate, endDate, price);

    return hallBooking;
    }

    public Dictionary<string, int> HallBookedCount(List<HallBooking> list)
    {
        Dictionary<string, int> hallBookingCount = new Dictionary<string, int>();

        foreach (HallBooking hallBooking in list)
        {
            string hallName = hallBooking.HallInstance.Name;

            if (hallBookingCount.ContainsKey(hallName))
            {
                hallBookingCount[hallName]++;
            }
            else
            {
                hallBookingCount.Add(hallName, 1);
            }
        }

        return hallBookingCount;
    }
}
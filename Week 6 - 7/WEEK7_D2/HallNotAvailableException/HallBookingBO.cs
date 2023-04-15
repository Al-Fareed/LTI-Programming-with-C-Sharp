using System;
using System.Collections.Generic;

class HallBookingBO
{
   static  List<string> bookedHalls = new List<string>();

    public static bool ValidateHallBooking(List<HallBooking> bookings, HallBooking hallBooking)
    {
        if (HallBookingBO.bookedHalls.Contains(hallBooking.HallInstance.Name))
        {
            return false;
        }

        HallBookingBO.bookedHalls.Add(hallBooking.HallInstance.Name);

        return true;
    }
}

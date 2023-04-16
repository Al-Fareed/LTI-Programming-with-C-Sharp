using System;
using System.Collections.Generic;
class Hall
{
    string _hallName;
    double _costPerDay;
    DateTime _bookingDate;
    string _ownerName;
    public Hall() { }
    public string HallName
    {
        get => _hallName;
        set => _hallName = value;
    }
    public double CostPerDay
    {
        get => _costPerDay;
        set => this._costPerDay = value;
    }
    public DateTime BookingDate
    {
        get => _bookingDate;
        set => _bookingDate = value;
    }
    public string OwnerName
    {
        get => _ownerName;
        set => _ownerName = value;
    }
    public Hall(string _hallName, double _costPerDay, DateTime _bookingDate, string _ownerName)
    {
        this._hallName = _hallName;
        this._costPerDay = _costPerDay;
        this._bookingDate = _bookingDate;
        this._ownerName = _ownerName;
    }
    public static Hall CreateHall(string hallDetail)
    {
        string[] input = hallDetail.Split(",");
          DateTime bookingDate = DateTime.ParseExact(input[2], "dd-MM-yyyy", null);
           Hall newHall = new Hall(input[0], double.Parse(input[1]),bookingDate, input[3]);
            return newHall;


    }
    public List<Hall> FilterHall(List<Hall> hallList, Predicate<double> predicate)
    {
        List<Hall> filteredHallList = new List<Hall>();
        foreach (Hall hall in hallList)
        {
            if (predicate.Invoke(hall._costPerDay))
            {
                filteredHallList.Add(hall);
            }

        }

        return filteredHallList;
    }
    public void DisplayHallDetails(List<Hall> hallList)
    {
        if (hallList.Count == 0)
        {
            Console.WriteLine("No hall for that range.");
        }
        else
        {
           Console.WriteLine("{0} {1,15} {2,15} {3,15}", "Hall name", "Cost per day", "Booking date", "Owner name");
            foreach (Hall hall in hallList)
            {
                Console.WriteLine("{0} {1,15} {2,15} {3,15}", hall.HallName, string.Format("{0:0.0}",hall.CostPerDay), hall.BookingDate.ToString("dd-MM-yyyy"), hall.OwnerName);
                
            }
        }
    }
}

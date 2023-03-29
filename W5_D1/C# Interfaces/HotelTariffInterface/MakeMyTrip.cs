using System;
using System.Collections.Generic;

public class MakeMyTrip : HotelTariff
{
    Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
            "Tokyo",
            new Dictionary<string,double>
            {
                {"Tokyo Residency",10000},
                {"Heritage Tokyo",15000},
                {"Germanus",20000}
            }
        },
        {
            "Singapore",
            new Dictionary<string,double>
            {
                {"Hotel CAG Pride",15000},
                {"Heritage Inn",25000}
            }
        }
    };

    public void CityList()
    {
        foreach (var city in HotelList.Keys)
        {
            Console.WriteLine(city);
        }
    }

    public void ShowTariff(string city)
    {
        if (HotelList.ContainsKey(city))
        {
            Console.WriteLine("Hotel List with Tariff:");
            foreach (var hotel in HotelList[city])
            {
                Console.WriteLine("{0} - Rs.{1}", hotel.Key, hotel.Value);
            }
        }
        else
        {
            Console.WriteLine("Selected City not found...");
        }
    }
}

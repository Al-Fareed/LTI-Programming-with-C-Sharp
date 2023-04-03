using System;
using System.Collections.Generic;
public class Trivago : HotelTariff//Fill your code here
{
    Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Hyderabad",
        new Dictionary<string,double>
        {
            {"Park Hyatt",12000},
            {"Courtyard By Marriott",10000},
            {"Taj Krishna",14500}
        }
        },

        {
        "Mysore",
        new Dictionary<string,double>
        {
            {"Hotel Royal Orchid",20000},
            {"Hotel Kings Kourt",18000}
        }
        }
    };
    //Fill your code here
    public void CityList()
    {
        //Fill your code here
        foreach (string item in HotelList.Keys)
        {
            Console.WriteLine(item);
        }
    }

    public void ShowTariff(string city)
    {
        //Fill your code here
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
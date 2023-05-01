/*
Filter Hall using the Predicate
Create class Hall with following variables/ attributes,
Variable name	Data type
_hallName	string
_costPerDay	double
_bookingDate	DateTime
_ownerName	string
Include appropriate properties.
Include a default and a parameterized constructor with the following order (string _hallName, double _costPerDay, DateTime _bookingDate, string _ownerName).

Include the following methods,
Sno	Method name	Method description
1	Hall CreateHall(string hallDetail)	This method is used to create a hall object using the parameterized hallDetail(which is comma seperated). Split that string and create a hall object using the parameterized constructor and return that created hall object.
2	List<Hall> FilterHall(List<Hall> hallList, Predicate<double> predicate)	This method is used to filter the parameterized hallList using the parameterized Predicate object. Use Invoke method for predicate object with the hall's cost per day. The definition will be give in Main method and that defined object is passed as parameter(predicate).
3	void DisplayHallDetails(List<Hall> hallList)	This method is used to display the hall details using t he parameterized hallList. If there is no hall in that hallList, then print "No hall for that range.". Otherwise print the hall details as for as sample output


Create Program class with Main method, get number of halls, hall details, minimum and maximum price to filter the halls.
Filter the halls matching the filter condition. Display the filtered hall details.

Predicate:
A Predicate returns true or false. This C# type stores a method that receives 1 parameter and returns 1 value of true or false. And it is often used with lambda expression syntax.

Note: During the filtration of hall list, the maximum and minimum cost is included.


Input a nd  Output Format: 
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output. 


Sample Input and Output:
Enter the number of halls:
10
Enter hall-1 details:
Residency,34600.0,12-10-2017,Larry
Enter hall-2 details:
MG Hall,26400.0,23-11-2017,William
Enter hall-3 details:
Bee Gee,24000.0,13-11-2017,David
Enter hall-4 details:
Manas,35000.0,18-12-2017,Guetta
Enter hall-5 details:
Milad Tower Hall,28500.0,28-12-2017,Franklin
Enter hall-6 details:
Roudaki Hall,36500.0,12-11-2017,Lincoln
Enter hall-7 details:
TCC Music Hall,45000.0,15-01-2018,Christian
Enter hall-8 details:
Centennial Hall,28900.0,24-01-2018,Bale
Enter hall-9 details:
Forbes Hall,55600.0,29-12-2017,Jerry
Enter hall-10 details:
Meng Hall,29500.0,03-01-2018,Brown
Enter the minimum price to filter:
20000
Enter the maximum price to filter:
30000
Hall name    Cost per day    Booking date      Owner name
MG Hall         26400.0      23-11-2017         William
Bee Gee         24000.0      13-11-2017           David
Milad Tower Hall         28500.0      28-12-2017        Franklin
Centennial Hall         28900.0      24-01-2018            Bale
Meng Hall         29500.0      03-01-2018           Brown

Sample Input and Output 2:

 

 

Enter the number of halls:
 

 

10
Enter hall-1 details:
Residency,34600.0,12-10-2017,Larry
Enter hall-2 details:
MG Hall,26400.0,23-11-2017,William
Enter hall-3 details:
Bee Gee,24000.0,13-11-2017,David
Enter hall-4 details:
Manas,35000.0,18-12-2017,Guetta
Enter hall-5 details:
Milad Tower Hall,28500.0,28-12-2017,Franklin
Enter hall-6 details:
Roudaki Hall,36500.0,12-11-2017,Lincoln
Enter hall-7 details:
TCC Music Hall,45000.0,15-01-2018,Christian
Enter hall-8 details:
Centennial Hall,28900.0,24-01-2018,Bale
Enter hall-9 details:
Forbes Hall,55600.0,29-12-2017,Jerry
Enter hall-10 details:
Meng Hall,29500.0,03-01-2018,Brown
Enter the minimum price to filter:
10000
Enter the maximum price to filter:
15000
No hall for that range.
*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Hall> hallList = new List<Hall>();

        Console.WriteLine("Enter the number of halls:");
        int noOfHalls = int.Parse(Console.ReadLine());

        for (int i = 1; i <= noOfHalls; i++)
        {
            Console.WriteLine($"Enter hall-{i} details:");
            string input = Console.ReadLine();
            hallList.Add(Hall.CreateHall(input));
        }
        Hall hall = new Hall();
        Console.WriteLine("Enter the minimum price to filter:");
        double minPrice = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the maximum price to filter:");
        double maxPrice = double.Parse(Console.ReadLine());
        Predicate<double> costPred = delegate (double costPerDay) { 
            return costPerDay >= minPrice && costPerDay <= maxPrice; };
        List<Hall> filteredList = hall.FilterHall(hallList, costPred);
        hall.DisplayHallDetails(filteredList);
    }
}
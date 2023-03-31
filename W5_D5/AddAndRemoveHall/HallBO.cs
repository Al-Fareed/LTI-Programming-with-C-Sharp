using System;
using System.Collections.Generic;


class HallBO
{
    public Hall CreateHall(string hallDetails)
    {
        //fill code here
        string[] details = hallDetails.Split(",");
        string name = details[0];
        string contactNumber = details[1];
        double cost = double.Parse(details[2]);
        string oName = details[3];
        Hall hall = new Hall();
        hall.Name = name;
        hall.ContactNumber = contactNumber;
        hall.CostPerDay = cost;
        hall.OwnerName = oName;
        return hall;
    }
    public bool RemoveHallFromList(List<Hall> hallList, int index)
    {
        //fill code here
        if (hallList.Count == 0)
        {
            return false;
        }
        if (index - 1 < hallList.Count)
        {
            hallList.RemoveAt(index - 1);
            if (hallList.Count > 0)
            {
                DisplayHalls(hallList);
                return true;
            }
            else
            {
                Console.WriteLine("Hall list empty");
                return true;
            }
        }
        else
        {
            return false;
        }

    }
    public void DisplayHalls(List<Hall> hallList)
    {
        Console.WriteLine("{0}{1,15}{2,15}{3,15}", "Name", "Contact Number", "Cost per day", "Owner Name");
        foreach (Hall halls in hallList)
        {
            Console.WriteLine("{0}{1,15}{2,15}{3,15}", halls.Name, halls.ContactNumber, halls.CostPerDay, halls.OwnerName);
        }
       
    }
}
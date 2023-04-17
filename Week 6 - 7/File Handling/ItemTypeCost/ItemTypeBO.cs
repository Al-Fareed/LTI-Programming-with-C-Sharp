using System;
using System.IO;
using System.Collections.Generic;
public class ItemTypeBO
{
    public List<ItemType> AddItemType(string details, List<ItemType> itemList)
    {
        string name = details.Substring(0, 15).Trim();
        double deposit = double.Parse(details.Substring(15, 10).Trim());
        double costPerDay = double.Parse(details.Substring(25, 10).Trim());
        Console.WriteLine("{0},{1},{2}", name, deposit, costPerDay);
        itemList.Add(new ItemType(name, deposit, costPerDay));
        return itemList;
    }
    public void Display(List<ItemType> list)
    {

        Console.WriteLine("Item Type having deposit greater than Rs.20000 are:");
        bool found = true;
        foreach (ItemType item in list)
        {
            if (item.Deposit > 20000)
            {
                Console.WriteLine("ItemType Name: {0}\nDeposit Amount: {1}\nCost Per Day: {2}", item.Name, item.Deposit, item.CostPerDay);
            }
            else
            {
                found = false;
            }
        }
        if (!found)
        {
            Console.WriteLine("Item Type with deposit more than Rs.20000 is not found...");
        }
    }
}
/*
Item Type Count
[Note :
Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create class ItemType with the following private variables/attributes.
Data Type	Variable
string	_name
double	_deposit
double	_costPerDay

Include appropriate properties.
Include a default constructor and a three argument constructor with parameters in the following order _name,  _deposit, _costPerDay.

Pre-populate the ItemType type details and store it in list.
Name	Deposit	Cost per day
Decorations	15000	10000
Electronics	2500	1500
Furniture	7500	3500

Create class Item with the following private variables/attributes.
Data Type	Variable
string	_name
ItemType	_itemTypeInstance
string	_vendorName

Include appropriate properties.
Include a default constructor and a three argument constructor with parameters in the following order _name,  _itemTypeInstance, _vendorName.

Create class ItemBO with the following methods.
Method	Description
public Item CreateItem(string data)	In this method, create ItemType object with the given data and return the object.
public Dictionary<string, int> ItemtypeCount (List<Item> list)	This method is used to calculate the count of each item type and store item type and its count in a dictionary.

Create Program class with Main method to test the above classes.
Read the input file using StreamReader.
Read the lines from the input file and create item object by parsing the input. Add all the item object to the List.
Use Dictionary to store the item type name and the count of items in the corresponding item type.
Display all the item type and its count.


Input Format:
The input file name must be "input.txt".
The input file consists of a set of item details in fixed length.

Field	Start Index	Size
Name	1	10
ItemType name	11	12
Vendor name	23	10

Output Format:
String.Format("{0,-15} {1,-10}", "Item Type", "Count")

Sample Output :
Item type with number of items
Item Type       Count
Electronics     2
Furniture       1
Decorations     1
*/
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //fill code here
        List<Item> itemList = new List<Item>();
        Dictionary<string, int> itemTypeCountDict = new Dictionary<string, int>();
        List<ItemType> itemTypeList = ItemType.GetItemType();
        ItemBO itemBO = new ItemBO();

    using (StreamReader sr = new StreamReader("input.txt"))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            Item item = itemBO.CreateItem(line);
            itemList.Add(item);

            string itemType = item.ItemTypeInsance.Name;
            if (itemTypeCountDict.ContainsKey(itemType))
            {
                itemTypeCountDict[itemType]++;
            }
            else
            {
                itemTypeCountDict.Add(itemType, 1);
            }
        }
    }
    Console.WriteLine("Item type with number of items");
    Console.WriteLine("{0,-15} {1,-10}", "Item Type", "Count");
    foreach (KeyValuePair<string, int> kvp in itemBO.ItemtypeCount(itemList))
    {
        Console.WriteLine("{0,-15} {1,-10}", kvp.Key, kvp.Value);
    }
}
}
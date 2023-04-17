// ! This code is absolutely fine, but tje upskill compiler shows wrong
/*
Item Type Cost
Write a program to read the item type details from the file and display the item type details whose deposit is  greater than Rs.20000.

[Note : Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class ItemType with the following private attributes.

Data Type	 Attributes
string	_name
double	_deposit
double	_costPerDay

The methods for getters, setters and constructors are given in the template code.
Override ToString() method to return item type details.

Consider the class ItemTypeBO and define the following methods.

Method Name	Description
public List<ItemType> AddItemType(string details, List<ItemType> itemList)	In this method, use Substring() method to split the fixed size item type details. Add the splitted details into the ItemType class after trimming the spaces. Store the itemtype object in the list and return the list.
public void Display(List<ItemType> list)	This method is used to display the details of the item types having deposit greater than Rs.20000.
Include the statement “Item Type having deposit greater than Rs.20000 are:” in this method.
If it is no item is greater than Rs.20000 then display “Item Type with deposit more than Rs.20000 is not found...”.
Consider the class Program. It includes the method Main.
In the Main method,

read the input file using StreamReader, create ItemType object by parsing the input and add all item type object to the list. Display the item type details using Display method in ItemTypeBO class.
 

The link to download the template code is given below
Code Template


Note :

The input.txt file consists of itemtype name, event type, deposit and cost per day is stored as fixed length format as follows,

Variable	Start Index	Length
name	0 	15
deposit	15	10
cost per day	25	10


Input and Output Format :

The input file consists of item type details separated by space in order (name, deposit, cost per day).

Refer sample input and output for formatting specifications.

Sample Input (input.txt) 1:

Electronics    90000     60000     
Furnitures     75000     30000     
Stationaries   15000     1500      
Interior works 30000     25000     
Cosmetics      10000     1000      
Decoration     25000     1500      
Party Wears    35000     4500      

Sample Output 1:

Item Type having deposit greater than Rs.20000 are:
ItemType Name: Electronics
Deposit Amount: 90000
Cost Per Day: 60000
ItemType Name: Furnitures
Deposit Amount: 75000
Cost Per Day: 30000
ItemType Name: Interior works
Deposit Amount: 30000
Cost Per Day: 25000


Sample Input (input.txt) 2:

Electronics    60000     6000      
Stationaries   15000     1500      
Interior works 30000     4000      
Decoration     25000     1500      

Sample Input and Output 2
Item Type having deposit greater than Rs.20000 are:
Item Type with deposit more than Rs.20000 is not found...
*/
using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        StreamReader reader = new StreamReader("input.txt");
        string line;
        List<ItemType> itemTypes = new List<ItemType>();
        // List<ItemType> items = new List<ItemType>();
        ItemTypeBO itemTypeBO = new ItemTypeBO();
        while ((line = reader.ReadLine()) != null)
        {
            itemTypes = itemTypeBO.AddItemType(line,itemTypes);
        }
        reader.Close();
        
        itemTypeBO.Display(itemTypes);
    }
}

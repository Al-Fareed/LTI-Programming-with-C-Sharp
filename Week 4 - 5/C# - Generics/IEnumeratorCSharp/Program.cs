/*

IEnumerator - C#
[Note :
Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create class Stall with the following private member variables/attributes.
Data Type	Variable
string	_name
string	_owner
string	_detail

In Stall class add a public attribute static List<Stall>, to store stall details.
Include appropriate properties.
Include three-argument   constructor with parameters in the following order,
public Stall(string _name, string _owner, string _detail)
Override ToString() method in the Stall class to display the Stall details as in the output format.

Create Program class with Main method, get the number of stalls and stall details from the user.
Get stall details as a comma seperated string in following order.(name,owner,detail).
Use IEnumerator class to iterate the stall list and if the stall name starts with test remove it from the list.
Display the updated stall list.

Input and  Output Format  
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output. 
Sample Input And Ouput 1:
Enter total number of stalls
3
food plaza,john,foods of multiple cuisine
have it your way,peter,customized gifts
test salt and bakery,mbappe,bakery items
Updated Stall List
Name : food plaza
Owner : john
Details : foods of multiple cuisine
Name : have it your way
Owner : peter
Details : customized gifts

Sample Input And Output 2:
Enter total number of stalls
3
The Godfather,shaw,novels
test salt and bakery,mbappe,bakery items
test Chain and Reaction,ozil,Pcs and Ps DVDs
Updated Stall List
Name : The Godfather
Owner : shaw
Details : novels


*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter total number of stalls");
        int noOfStalls = int.Parse(Console.ReadLine());
        List<Stall> stallList = new List<Stall>();
        for (int i = 0; i < noOfStalls; i++)
        {
            string[] stallName = Console.ReadLine().Split(",");
            
            if (!stallName[0].StartsWith("test") || stallName[0].StartsWith("Test"))
            {
                Stall stall = new Stall(stallName[0], stallName[1], stallName[2]);
                stallList.Add(stall);
            }
        }
        Console.WriteLine("Updated Stall List");
        IEnumerator<Stall> stallEnum = stallList.GetEnumerator();
        while(stallEnum.MoveNext()){
            Stall stallName = stallEnum.Current;
            Console.WriteLine(stallName);
        }
    }
}

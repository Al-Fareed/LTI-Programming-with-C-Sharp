/*
Dictionary c#
Happy Deals is a famous event management company. Their online event management system has a good reach among the people. So, as an extension to the services offered, they wanted to show case various halls in which they can organise events. For this purpose, they wanted to collect the hall owner name and the hall names that he owns.

Write a program to read the hall details and display the same using Dictionary.

Problem Specifications: 
The Main Class file name should be Program.cs and the class name should be Program.
Read owner name followed by a list of hall names.
Store all the values in a Dictionary- Owner name is the key and list of hall names will be the value.
Get the owner name from the user and display all his hall names from the list

Input and Output Format:
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input And Output 1:
Enter the total number of hall owners
2
Enter owner name 1
ram
Enter total number of halls owned by ram
1
Enter list of halls owned by ram
ram party hall
Enter owner name 2
raju
Enter total number of halls owned by raju
2
Enter list of halls owned by raju
raju marriage hall
ABC conference hall
Owner Name : ram
Halls Owned :
ram party hall
Owner Name : raju
Halls Owned :
raju marriage hall
ABC conference hall

Sample Input And Output 2:
Enter the total number of hall owners
3
Enter owner name 1
john
Enter total number of halls owned by john
2
Enter list of halls owned by john
john event management hall
john meditation hall
Enter owner name 2
rollins
Enter total number of halls owned by rollins
1
Enter list of halls owned by rollins
rollins indoor hall
Enter owner name 3
ambrose
Enter total number of halls owned by ambrose
1
Enter list of halls owned by ambrose
ambrose party hall
Owner Name : john
Halls Owned :
john event management hall
john meditation hall
Owner Name : rollins
Halls Owned :
rollins indoor hall
Owner Name : ambrose
Halls Owned :
ambrose party hall
*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        
        Console.WriteLine("Enter the total number of hall owners");
        int length = int.Parse(Console.ReadLine());
        Dictionary<string, List<string>> dList = new Dictionary<string, List<string>>();
        for (int i = 1; i <= length; i++)
        {
            Console.WriteLine("Enter owner name " + i );
            string name = Console.ReadLine();

            Console.WriteLine($"Enter total number of halls owned by {name}");
            int noOfHalls = int.Parse(Console.ReadLine());
            
            Console.WriteLine($"Enter list of halls owned by {name}");
            List<string> hallName = new List<string>();
            
            for (int j = 0; j < noOfHalls; j++)
            {
                hallName.Add(Console.ReadLine());
            }
            dList.Add(name,hallName);
        }
        foreach (string name in dList.Keys)
        {
            Console.WriteLine($"Owner Name : {name}\nHalls Owned :");
            
            foreach (string halls in dList[name])
            {
                Console.WriteLine(halls);
            }
        }
    }
}
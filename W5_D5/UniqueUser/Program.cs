/*
Unique User
Tata Steel uses a software system called EMS (Event Management System) for managing seminars and meetings within the departments. Employees can use this system to reserve meeting space and specify technical services for their events. An employee can reserve a hall number of times. EMS admin wants to find the number of employees who have used EMS for their events.

Write a program to display the number of unique users.

Consider the class Program and write a Main method to find the unique users count. Use HashSet to store the username. If the input is blank add null value to the set.

The link to download the template code is given below
Code Template


Input Format:

First line corresponds to the total number of users. 
Next n lines corresponds to the name of the users.

Output Format:

The output should display an integer value that gives the count of unique users. 

Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]


Sample Input and Ouput 1:

Enter the size of the userlist
4
Devin
Adelina
Devin
Adelina
Total number of unique users 2

Sample Input and Output 2:

Enter the size of the userlist
4
 
 
 
john
Total number of unique users 1
 

Program
*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the size of the userlist");
        int n = int.Parse(Console.ReadLine());
        HashSet<string> uList = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            if (!uList.Contains(name) && name!="")
            {
                uList.Add(name);
            }
        }
        Console.WriteLine("Total number of unique users "+uList.Count);
    }
}
/*
Find Hall name
A number of business houses and corporate are approaching the convention centers for conducting their seminars and conferences.  Write a program to read various hall names and make it easy for the corporates to search for a particular hall based on hall name.

Consider the class Program and write a Main method to search the hall. Use List with generic type string. Read the hall names from the user. Store the data in a list and search for a particular hall. Display the hall name that was being searched along with its position.
The link to download the template code is given below
Code Template

Input Format:
First input is an integer "n" that corresponds to the number of hall names.
Second ‘n’ input corresponds to a list of hall names.
Third input is a string that corresponds to the hall name that has to be searched.

Output Format:
Output should display the hall name and index of the hall name in the list.
If no hall name is found, then display "Hall name not found".
Refer sample input and output for formatting specifications.
 
[All text in bold corresponds to the input and rest corresponds to the output.]

Sample Input and Output 1 :
3
The Great Hall
Royal Festival Hall
Cadogan Hall
Enter the hall name to search
Cadogan Hall
Hall name Cadogan Hall found at index 2

Sample Input and Output 2 :
3
The Great Hall
Queen Elizabeth Hall
Royal Festival Hall
Enter the hall name to search
Royal Hall
Hall name not found 
*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<string> hallList = new List<string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            // string hall=Console.ReadLine();
            hallList.Add(Console.ReadLine());
        }
        System.Console.WriteLine("Enter the hall name to search");
        string hall = Console.ReadLine();
        if (hallList.Contains(hall))
        {
            Console.WriteLine("Hall name " + hall + " found at index " + hallList.IndexOf(hall));
        }
        else
            Console.WriteLine("Hall name not found");
    }
}
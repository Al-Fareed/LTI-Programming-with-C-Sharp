/*
Find Unique Hall
Raquel is the director of an Event management company. She decided to manage all the event details using an application. Franziska helped them in creating an application. Now they have started using the application. While uploading the hall details, they found that there are dual entries in some of the hall.
 

Help them to write a C# program to get the hall names from the user and display the unique hall names and use IEnumerator to iterate the set.
 

Consider Program class with Main method, get the list of hall names and display the unique hall entries.
 

The link to download the template code is given below
Code Template

 

Input and Output Format :
Display the unique halls in insertion order.
Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input And Ouput 1:

Enter the hall name
Hall Paradise
Do you want to add hall?(Yes/No)
Yes
Enter the hall name
Rudolfinum
Do you want to add hall?(Yes/No)
Yes
Enter the hall name
The Walt Disney Concert Hall
Do you want to add hall?(Yes/No)
Yes
Enter the hall name
Rudolfinum
Do you want to add hall?(Yes/No)
No
Unique halls
Hall Paradise
Rudolfinum
The Walt Disney Concert Hall
*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        string response;
        //Fill your code here
        List<string> hallList = new List<string>();
        do
        {
            Console.WriteLine("Enter the hall name");
            //Fill your code here
            string hallName=Console.ReadLine();
            if(!hallList.Contains(hallName))
            {
                hallList.Add(hallName);
            }
            Console.WriteLine("Do you want to add hall?(Yes/No)");
            response = Console.ReadLine();
            //Fill your code here
        }
        while (response == "Yes");
        Console.WriteLine("Unique halls");
        IEnumerator<string> hallEnum = hallList.GetEnumerator();
        while(hallEnum.MoveNext())
        {
            string hall = hallEnum.Current;
            Console.WriteLine(hall);
        }
    }
}

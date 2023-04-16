/*
Invalid Date Exception
Write a program to check whether the input date is in the valid format or not.

Create  Program class with Main method, get the starting and ending date-time of the Stage Event show from the user.
If the input date-time is given in the specified format, then display the starting and ending date-time.
Use try catch block to catch the exception and display the error message.
 
The link to download the template code is given below
Code Template

Input and Output Format:
The format for the date is dd/MM/yyyy hh:mm:ss tt
Refer sample input and output for formatting specifications.
[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input and Output 1:
Enter the start date(dd/MM/yyyy hh:mm:ss tt):
18/01/2018 09:00:00 AM
Enter the end date(dd/MM/yyyy hh:mm:ss tt):
18/01/2018 12:30:00 PM
Starting Date: 18/01/2018 09:00:00 AM
Ending Date: 18/01/2018 12:30:00 PM

Sample Input and Output 2:
Enter the start date(dd/MM/yyyy hh:mm:ss tt):
01/25/2017 09:00:00 AM
Enter the end date(dd/MM/yyyy hh:mm:ss tt):
01/25/2017 11:00:00 AM
Invalid Date Format...

Sample Input and Output 3:
Enter the start date(dd/MM/yyyy hh:mm:ss tt):
25/01/2018 14:00:00
Enter the end date(dd/MM/yyyy hh:mm:ss tt):
25/01/2018 16:00:00
Invalid Date Format...
*/
using System;

public class InvalidDateException : Exception
{
    public InvalidDateException(string message) : base(message) { }
}
public class Program : Exception
{
    public static void Main()
    {
        Console.WriteLine("Enter the start date(dd/MM/yyyy hh:mm:ss tt):");
        string start = Console.ReadLine();
        Console.WriteLine("Enter the end date(dd/MM/yyyy hh:mm:ss tt):");
        string end = Console.ReadLine();
        //fill your code
        DateTime sDate, eDate;
        try
        {
            if (!DateTime.TryParseExact(start, "dd/MM/yyyy hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out sDate))
            {
                throw new FormatException("Invalid Date Format...");
            }
            else if (!DateTime.TryParseExact(end, "dd/MM/yyyy hh:mm:ss tt", null, System.Globalization.DateTimeStyles.None, out eDate))
            {
                throw new FormatException("Invalid Date Format...");
            }
            else
            {
                Console.WriteLine("Starting Date: "+string.Format("{0:dd/MM/yyyy hh:mm:ss tt}",sDate));
                Console.WriteLine("Ending Date: "+string.Format("{0:dd/MM/yyyy hh:mm:ss tt}",eDate));
            }
        }
        catch(FormatException e){
            Console.WriteLine(e.Message);
        }
    }
}

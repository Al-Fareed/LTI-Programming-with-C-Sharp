/*
GroupBy and OrderBy in Linq

 

Devin joined as a placement director. He has to analyze all the drives for the academic year 2020 and display the students who’ve got placed in various companies. The student names need to be in ascending order. 

Write a program to get the number of students placed ‘n’ and the name of students who have got placed and the company names in which they got placed a list. 

[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class PlacedStudent with the following private attributes,

Data type	Attribute
string	_companyName
string	_studentName
The methods for getters, setters and constructors are given in the template code.

 

Consider the class Program. It includes the method Main.
In the Main method,

read the student details from the user, write a linq query to display the placed students name in ascending order grouped by the company name.
 

The link to download the template code is given below
Code Template

 

Note :

Use GroupBy and OrderBy operator in LINQ.

 

Input and Output Format :

Display the placed students name in ascending order.
Refer sample input and output for formatting specifications. 
[All text in bold corresponds to input and rest corresponds to output.]

Sample Input and Output 1:

Enter number of companies
4
Enter company name
ABC Tech
Enter student name
Devin
Enter company name
BTS
Enter student name
Peter
Enter company name
ABC Tech
Enter student name
Antonio
Enter company name
BTS
Enter student name
kanwald
Company Name : ABC Tech
Antonio
Devin
Company Name : BTS
kanwald
Peter
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        //Fill your code here
        List<PlacedStudent> placedStudents = new List<PlacedStudent>();

        Console.WriteLine("Enter number of companies");
        int noOfCompanies = int.Parse(Console.ReadLine());

        for (int i = 0; i < noOfCompanies; i++)
        {
            Console.WriteLine("Enter company name");
            string compName = Console.ReadLine();

            Console.WriteLine("Enter student name");
            string studName = Console.ReadLine();

            placedStudents.Add(new PlacedStudent(compName, studName));
        }
        // var studentsDetails = placedStudents.OrderBy(x => x.StudentName).GroupBy(y => y.CompanyName).ToList();
        var studentsDetails = from details in placedStudents
                              orderby details.StudentName ascending
                              group details.StudentName by details.CompanyName;

        foreach (var company in studentsDetails)
        {
            Console.WriteLine("Company Name : " + company.Key);

            foreach (var students in company)
            {
                Console.WriteLine(students);
            }
        }


    }
}

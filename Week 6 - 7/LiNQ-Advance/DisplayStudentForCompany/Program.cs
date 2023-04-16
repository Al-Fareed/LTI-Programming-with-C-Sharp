/*
Display Student For Company
The Placement director has a list of student names and company id to which the student got placed. He also has a list of company names with id. Now he wants to know the company name and students who got placed in that company.

Write a linq query to retrieve the company name and group the students based on company in which they are placed.

[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Company with the following private attributes
Data Type	Attributes
int	_id
string	_name

The methods for getters, setters and constructors are given in the template code.

Consider the class Student with the following private attributes
Data Type	Attributes
int	_id
string	_name
int	_companyId

The methods for getters, setters and constructors are given in the template code.
Consider the class Program. It includes the method Main.
In the Main method,

read the company and student details from the user, write a linq query to find the company name and list of students who got placed in that company. User two list to store company objects and student objects.
 

The link to download the template code is given below
Code Template


Note :
Use Join to get placed student for company.

Input and Output Format :

The first m and m*2 inputs corresponding to number of companies and company details (company id, company name).
The next n and n*3 inputs corresponding to number of students and student details (student id, student name, company id). 
Display the company name and its placed student only if the company have placed students.
Refer sample input and output for formatting specifications. 

[All text in bold corresponds to input and rest corresponds to output.]


Sample Input and Output 1:

Enter number of companies
2
Enter company 1 details
11
ServiceNow
Enter company 2 details
12
Intel
Enter number of students
3
Enter student 1 details
111233
Devin
11
Enter student 2 details
111256
Antonio
12
Enter student 3 details
111274
Saahir
11
ServiceNow
Devin
Saahir
Intel
Antonio


Sample Input and Output 2: 

Enter number of companies
2
Enter company 1 details
1
Square Technology
Enter company 2 details
2
Visa Academy
Enter number of students
1
Enter student 1 details
20012
Zahra
1
Square Technology
Zahra
*/
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // read number of companies and their details
        Console.WriteLine("Enter number of companies");
        int m = int.Parse(Console.ReadLine());
        List<Company> companies = new List<Company>();
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine($"Enter company {i+1} details");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            companies.Add(new Company(id, name));
        }

        // read number of students and their details
        Console.WriteLine("Enter number of students");
        int n = int.Parse(Console.ReadLine());
        List<Student> students = new List<Student>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter student {i+1} details");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int companyId = int.Parse(Console.ReadLine());
            students.Add(new Student(id, name, companyId));
        }

        // query to retrieve company name and students who got placed in that company
        var query = from c in companies
                    join s in students on c.Id equals s.CompanyId
                    group s by c.Name into g
                    select new { CompanyName = g.Key, Students = g.Select(s => s.Name) };

        // display results
        foreach (var result in query)
        {
            Console.WriteLine(result.CompanyName);
            foreach (string student in result.Students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
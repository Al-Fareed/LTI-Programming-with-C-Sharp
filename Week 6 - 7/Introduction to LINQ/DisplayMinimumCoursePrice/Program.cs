/*
Display Minimum Course Price

The Code academy is offering n number of courses which has different fees based on course. Students finds difficulty in choosing the desired course within their budget. Hence group the categories of courses and show the minimum amount required for that course category. So write a C# program to display the courses grouped by the catagory and show minimum amount needed for that course.


[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Course with following private attributes,

Data Type	Attributes
string	_id
string	_name
string	_category
int	_price
The methods for getters, setters and constructors are given in the template code.

Consider the class Program. It includes the method Main.
In the Main method,

read the course details from the user and add it into arraylist, write a linq query to find minimum course price for each course category by grouping the courses.
 

The link to download the template code is given below
Code Template

 

Input and Output Format :

Display the minimum course price in each course category.
The course category should be displayed in insertion order.
Refer sample input and output for formatting specifications. 

[All text in bold corresponds to input and rest corresponds to output.]

Sample Input and Output 1:

Enter the number of Courses
5
Course 1 Details
Enter the id
1
Enter the name
Basic java
Enter the category
Java
Enter the price
15000
Course 2 Details
Enter the id
2
Enter the name
Advanced html and css
Enter the category
Web designing
Enter the price
5000
Course 3 Details
Enter the id
3
Enter the name
Core java
Enter the category
Java
Enter the price
25000
Course 4 Details
Enter the id
4
Enter the name
C and C++
Enter the category
Basic programs
Enter the price
13000
Course 5 Details
Enter the id
5
Enter the name
Basics Html
Enter the category
Web designing
Enter the price
700
Course { Name = Java, Price = 15000 }
Course { Name = Web designing, Price = 700 }
Course { Name = Basic programs, Price = 13000 }
*/
using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args){
        List<Course> courses = new List<Course>();

        Console.WriteLine("Enter the number of Courses");
        int noOfCourses = int.Parse(Console.ReadLine());

        for (int i = 0; i < noOfCourses; i++)
        {
            Console.WriteLine("Course {0} Details\nEnter the id",i+1);
            string id = Console.ReadLine();

            Console.WriteLine("Enter the name");
            string courseName = Console.ReadLine();

            Console.WriteLine("Enter the category");
            string category = Console.ReadLine();

            Console.WriteLine("Enter the price");
            int price = int.Parse(Console.ReadLine());

            courses.Add(new Course(id,courseName,category,price));
        }
         
         var minPrices = from Course c in courses
                        group c by c.Category into g
                        select new { Name = g.Key, Price = g.Min(c => c.Price) };
        
        foreach (var itemPrice in minPrices)
        {
            Console.WriteLine("Course {{ Name = {0}, Price = {1} }}",itemPrice.Name,itemPrice.Price);
        }
    }
}
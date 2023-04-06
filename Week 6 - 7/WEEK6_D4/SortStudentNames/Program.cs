/*

Sort Student Names
The GH public school is the one of the standard schools in Tokyo. The principal of this school needs 10th standard student's name in sorted order. The Administrative staff calls all the students and prepare a list of student names. Help her to sort the names using linq orderby.

Write a C# program to sort student the name using Linq.

[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Student with the following private attributes,

Data Type	Attributes
int	_id
string	_name
int	_age
The methods for getters, setters and constructors are given in the template code.

Consider the class Program. It includes the method Main.
In the Main method,

read the student details from the user, write a linq query to display the sorted student names.
 

The link to download the template code is given below
Code Template

Input and Output Format :
Display the student names in ascending order.
Refer sample input and output for formatting specifications. 

[All text in bold corresponds to input and rest corresponds to output.]
  

Sample Input and Output 1 :  
Enter the number of students
3
Student 1 Details
Enter the id
1
Enter the name
Ram
Enter the age
24
Student 2 Details
Enter the id
2
Enter the name
Steve
Enter the age
34
Student 3 Details
Enter the id
3
Enter the name
John
Enter the age
25
Sorted student names
John
Ram
Steve

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of students");
        int n = Convert.ToInt32(Console.ReadLine());
        List<Student> studentList = new List<Student>();
        string name;
        int id, age;

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Student {0} Details", (i + 1));
            Console.WriteLine("Enter the id");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name");
            name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            age = Convert.ToInt32(Console.ReadLine());

            //fill code here
            studentList.Add(new Student(id, name, age));
        }

        //fill code here
        var SortedNames = (from student in studentList
                           orderby student.Name
                           select student.Name
        );

        Console.WriteLine("Sorted student names");
        //fill code here
        foreach (string nameSorted in SortedNames)
        {
            Console.WriteLine(nameSorted);
        }

    }
}

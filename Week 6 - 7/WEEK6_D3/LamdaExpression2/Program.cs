/*
Lamda Expression 2
There is a test for recruiting students for a company called "CODE CHALLENGE".Every Student must have solved a certain number of problems given by the company.The company want to split the students based on the number of problems solved by students.
 The split up are given below
 less than 100
 between 100 and 200
 greater than 200
Can u help the company?. 
Create a class Student with following private attributes
_name -String
 _problemCount - int
Create three lambda expressions for CountLessthan100, CountBet100to200 and CountGreaterthan200.These expressions accept attribute problemCount.
Input Output Format:
Refer sample input and output for formatting specifications.
All text in bold corresponds to Input. 
Enter the number of students :
8
Enter the students :
Name :
Abi
ProblemCount :
56
Name :
Madhu
ProblemCount :
89
Name :
Moni
ProblemCount :
100
Name :
Haritha
ProblemCount :
199
Name :
Priya
ProblemCount :
250
Name :
Nisha
ProblemCount :
201
Name :
Anandhi
ProblemCount :
150
Name :
Vaishnavi
ProblemCount :
160
Students with ProblemCount less than 100 :
Abi - 56
Madhu - 89
Students with ProblemCount between 100 to 200(both inclusive) :
Moni - 100
Haritha - 199
Anandhi - 150
Vaishnavi - 160
Students with ProblemCount greater than 200 :
Priya - 250
Nisha - 201
*/
using System;
using System.Collections.Generic;
public delegate void CountLessthan100(List<Student> stud);
public delegate void CountBet100to200(List<Student> stud);
public delegate void CountGreaterthan200(List<Student> stud);

class Program
{
    static void Main(string[] args)
    {
        List<Student> studentList = new List<Student>();
        Console.WriteLine("Enter the number of students :");
        int noOfStudents = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the students :");
        for (int i = 0; i < noOfStudents; i++)
        {
            Console.WriteLine("Name :");
            string name = Console.ReadLine();
            Console.WriteLine("ProblemCount :");
            int problemCount = int.Parse(Console.ReadLine());
            studentList.Add(new Student(name, problemCount));
        }
        CountLessthan100 clt = (students) =>
        {
            Console.WriteLine("Students with ProblemCount less than 100 :");
            foreach (Student stud in students)
            {
                if (stud.ProblemCount < 100)
                {
                    Console.WriteLine("{0} - {1}", stud.Name, stud.ProblemCount);
                }
            }
        };

        CountBet100to200 cbt = (students) =>
        {
            Console.WriteLine("Students with ProblemCount between 100 to 200(both inclusive) :");
            foreach (Student stud in students)
            {
                if (stud.ProblemCount >= 100 && stud.ProblemCount <= 200)
                {
                    Console.WriteLine("{0} - {1}", stud.Name, stud.ProblemCount);
                }
            }
        };

        CountGreaterthan200 cgt = (students) =>
        {
            Console.WriteLine("Students with ProblemCount greater than 200 :");
            foreach (Student stud in students)
            {
                if (stud.ProblemCount > 200)
                {
                    Console.WriteLine("{0} - {1}", stud.Name, stud.ProblemCount);
                }
            }
        };
        clt.Invoke(studentList);
        cbt.Invoke(studentList);
        cgt.Invoke(studentList);
    }
}

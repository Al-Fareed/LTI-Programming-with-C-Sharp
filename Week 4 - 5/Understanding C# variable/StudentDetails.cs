/*
Student Details
 


When writing a program in programming language, the language supports variety of formats (types) through which data can be read from the user. Some of the commonly used formats are numbers, strings, decimals and so on. Lets try and use the various data types to collect student information.

Create a main class with the name "Program".

Input and Output Format:
Refer sample input and output for formatting specifications.

[All text in bold corresponds to input and the rest corresponds to output]

Sample Input and Output 1 :
Enter name :
Roger
Enter Roll No :
43
Enter Subject :
Operating Systems
Enter Marks :
91
Enter Grade :
A
Roger Details :
Roll No : 43
Subject : Operating Systems
Marks : 91.0
Grades : A

Sample Input and Output 2 :

Enter name :
Lee
Enter Roll No :
19
Enter Subject :
Android
Enter Marks :
78.9
Enter Grade :
C
Lee Details :
Roll No : 19
Subject : Android
Marks : 78.9
Grades : C

*/
using System;
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name :");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Roll No :");
            int rollNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Subject :");
            string subject = Console.ReadLine();

            Console.WriteLine("Enter Marks :");
            float marks = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter Grade :");
            char grade = char.Parse(Console.ReadLine());

            Console.WriteLine(name + " Details :");
            Console.WriteLine("Roll No : " + rollNo);
            Console.WriteLine("Subject : " + subject);
            Console.WriteLine("Marks : "+String.Format("{0:0.0}",marks));
            Console.WriteLine("Grades : " + grade);
        }

}

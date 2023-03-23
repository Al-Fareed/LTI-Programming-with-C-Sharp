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
class Program{
     void get(string data){
        Console.WriteLine("Enter {0} :",data);
    }
    void display(string data){
        Console.Write("{0} : ",data);
    }
 static void Main(String[] args) {
        Program p=new Program();
        p.get("name");
        string name=Console.ReadLine();
        p.get("Roll No");
        int rollNo=int.Parse(Console.ReadLine());
        p.get("Subject");
        string subject=Console.ReadLine();
        p.get("Marks");
        double marks=double.Parse(Console.ReadLine());
        p.get("Grade");
        string grades=Console.ReadLine();
        Console.WriteLine(name+" Details :");
        p.display("Roll No");
        Console.WriteLine(rollNo);
        p.display("Subject");
        Console.WriteLine(subject);
        p.display("Marks");
        Console.WriteLine(String.Format("{0:0.#}",marks));
        p.display("Grades");
        Console.WriteLine(grades); 
         }    
}
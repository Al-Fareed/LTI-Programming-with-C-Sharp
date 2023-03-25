/*
Grade Calculation

Write a program to determine the grade of the student in a particular subject. Refer to the table given below for grade details.

Marks scored	Grade
100	S
[90,100)	       A
[80,90)	           B
[70,80)	           C
[60,70)	           D
[50,60)	           E
<50	               F
The interval [a,b] includes all numbers greater than or equal to a and less than b.

 

Input and Output Format:
Input consists of a single integer that corresponds to the marks scored by the student.

Print "Invalid Input" if it is not in the range 0 to 100.

Refer sample input and output for formatting specifications.

[All text in bold corresponds to input and the rest corresponds to output.]

 

Sample Input and Output 1:
Enter the marks

85

B

Sample Input and Output 2:
Enter the marks

850

Invalid Input

 
*/
using System;
class Program{
    void print(string s){
        if(s.Length<2)
            Console.WriteLine("The student obtained a {0} grade",s);
        else
            Console.WriteLine("{0}",s);
    }
    static void Main(){
        Program p=new Program();
        Console.WriteLine("Enter the marks");
        int marks=int.Parse(Console.ReadLine());
        string Grade= marks==100? "S" 
                : marks>=90 && marks<100? "A"
                : marks>=80 && marks<90? "B"
                : marks>=70 && marks<80? "C"
                : marks>=60 && marks<70? "D"
                : marks>=50 && marks<60? "E"
                :  marks<50 && marks>=0? "F"
                : "Invalid Input";
            p.print(Grade);
                    
    }
} 
/*
Mathematical Operations using Delegate
 

Write C# program to add and subtract two values using generic delegates in one function call.

Create a delegate method named delegate void CalculateDelegate(int num1, int num2).

Define the following methods in Program class,

Method Name	Description
static void Addition(int num1, int num2)	This method is used to add the values and display the sum.
static void Subtract(int num1, int num2)	This method is used to subtract the values and display the subtracted value.
 

Consider the class Program. It includes the method Main.
In the Main method,

read the two values from the user, create a reference to the delegate and add the Addition, Subtract methods to it then invoke the delegates.
 

The link to download the template code is given below
Code Template

 


Input and Output Format :

Refer sample input and output for formatting specifications. 

[All text in bold corresponds to input and rest corresponds to output.]

Sample Input and Output 1:

Enter the num1
5
Enter the num2
2
The sum is : 7
The subtraction is : 3
*/
using System;
public delegate void CalculateDelgate(int num1,int nume2);
class Program
{
    static void Addition(int num1, int num2){
        Console.WriteLine("The sum is : "+(num1+num2));
    }
    static void Subtract(int num1, int num2){
        Console.WriteLine("The subtraction  is : "+(num1-num2));
    }
    static void Main(){
        Console.WriteLine("Enter the num1");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the num2");
        int num2 = int.Parse(Console.ReadLine());
        CalculateDelgate cd = new CalculateDelgate(Program.Addition);
        cd += Program.Subtract;
        cd.Invoke(num1,num2);
    }
}
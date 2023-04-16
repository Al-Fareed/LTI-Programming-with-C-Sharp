/**
Generic Method - Print

Write a c# program to print the value of the element passed as a input using generic method "Print".

Create class GenericClass with the following method

Method	 Description
public static void Print<T>(T element)	This method prints the value of the element.

Create Program class with Main method, get the input from the user. Call the Print method present in the GenericClass and display the specified result.

Refer sample input and output for formatting specifications.
All text in bold corresponds to input and the rest corresponds to output.

Sample Input and Output 1:
Enter the input :
Good Morning
Good Morning

 

Sample Input and Output 2:
Enter the input :
123
123
*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main(){
        Console.WriteLine("Enter the input :");
        var input = Console.ReadLine();
        GenericClass.Print(input);
    }
}
/*
Calculate Area and perimeter of rectangle
The manager gives a task for all employees to calculate the area and perimeter in one method call. But the same time there must be two different methods to display area and perimeter. He allows us to use any concept to complete this task. Raja knows the concept of delegates to point more than one method in a single call. But he doesn't know how to program using delegates. 

Help him to complete the task by writing a program to display area and perimeter of the rectangle.

Create a delegate method named void rectangleDelegate(double width, double height) in Program class.

Define the following methods in Program class 

Method Name	Description
void PrintArea(double width, double height)	This method is used to get the width and height of rectangle to calculate and display the area.
void PrintPerimeter(double width, double height)	This method get the width and height as input then calculate and display the perimeter of rectangle.
 

Consider the class Program. It includes the method Main.
In the Main method,

read the rectangle details from the user, create a reference to the delegate and add the PrintArea, PrintPerimeter methods to it then invoke the delegates.
 

The link to download the template code is given below
Code Template


Input and Output Format :

The first input corresponds to the rectangle width.

The second input corresponds to the rectangle height.

Refer sample input and output for formatting specifications. 

[All text in bold corresponds to input and rest corresponds to output.]


Sample Input and Output 1:

Enter the width
6.3
Enter the height
4.2
Area is: 26.46
Perimeter is: 21

 

Sample Input and Output 2:

Enter the width
5
Enter the height
7
Area is: 35
Perimeter is: 24 
*/
using System;
public delegate void rectangleDelegate(double width, double height);
class Program
{
    //fill code here

    public void PrintArea(double height, double width)
    {
        //fill code here
        Console.WriteLine("Area is: "+(height*width));
    }

    public void PrintPerimeter(double height, double width)
    {
        //fill code here
        Console.WriteLine("Perimeter is: "+(2*(height+width)));

    }

    static void Main(string[] args)
    {
        //fill code here
        Console.WriteLine("Enter the width");
        double width = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the height");
        double height = double.Parse(Console.ReadLine());
        Program p =new Program();
        rectangleDelegate calDelagate = new rectangleDelegate(p.PrintArea);
        calDelagate+=p.PrintPerimeter;
        calDelagate.Invoke(height,width);
    }
}

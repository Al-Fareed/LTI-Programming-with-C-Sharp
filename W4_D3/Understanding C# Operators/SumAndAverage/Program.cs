/*
A Day - to Day activity we all perform is finding the sum and average of a set of numbers. This may range from a shopping cart, to a hotel bill, to monthly expenses or even the mileage of our vehicles. The most common function that is used in Excel (Microsoft Office) would be sum and average. Lets write a program to compute this sum and average.
 
Create a main class with the name "Program".
 
Input Format:
 
The first input denotes the value of n, followed by n values from the user (assume them as double / float).

Note : The count has to be greater than 0, if not print "Invalid Input".
 
Output Format:
 
Display the sum and average of numbers maximum of 2 decimal places.
 
[All text in bold corresponds to input and the rest corresponds to output] 
 
Sample Input & Output 1:
Enter the count
5
Enter numbers
20.5
67
102
15
6
Sum of numbers is 210.5 average of numbers is 42.1
 
Sample Input & Output 2:
Enter the count
9
Enter numbers
25
106
32.25
15
70.5
30.55
25.69
2.5
15
Sum of numbers is 322.5 average of numbers is 35.8
*/
using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the count");
        int count= int.Parse(Console.ReadLine());
        double sum=0;
        if(count>0){
            Console.WriteLine("Enter numbers");
        for(int i=0;i<count;i++){
            double num=double.Parse(Console.ReadLine());
            sum=sum+num;
        }
        double avg=(double)(sum/count);
        Console.Write("Sum of numbers is "+String.Format("{0:0.0}",sum));
        Console.WriteLine(" average of numbers is "+String.Format("{0:0.0}",avg));
        }
        else{
            Console.WriteLine("Invalid Input");
        }
    }
}   
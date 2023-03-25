/*
Sum of digits
Write a program using a while loop to find the sum of digits of a given number.
Input Format :
Input consists of a positive integer value.
Output Format :
The output consists of the sum of digits in the input value.
Refer to Sample Input and Output for further details.
Sample Input 1 :
Enter the value :
1345
Sample Output 1 :
Sum of digits in 1345 is 13
Sample Input 2 :
Enter the value :
11111
Sample Output  2 :
Sum of digits in 11111 is 5
*/
using System;
class Program{
    static void Main(){
        Console.WriteLine("Enter the value :");
        int n=int.Parse(Console.ReadLine());
        int temp=n;
        int sum=0,rem;
        while(n>0){
            rem = n%10;
            sum += rem;
            n=n/10;
        }
        Console.WriteLine("Sum of digits in {0} is {1}",temp,sum);
    }
}
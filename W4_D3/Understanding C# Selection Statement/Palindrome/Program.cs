/*
Palindromic Prize

A customer in the Personalised Gift Store is awarded a prize when their bill number is a 3-digit palindrome.Write a program for identifying the prize winners.

 

Input Format:

Input consists of a number that corresponds to the bill number.


Output Format:

The output consists of a string that is either 'yes' or 'no'. The output is 'yes' when the customer receives the prize and is 'no' otherwise.

 

Sample Input 1:

565

Sample Output 1:

yes

 

Sample Input 2:

568

Sample Output 2:

no

 

Sample Input 3:

66

Sample Output 3:

no
*/
using System;
class Program{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int temp=n;
        int rev=0,rem=0;
        while(n>0){
            rem=n%10;
            rev=(rev*10)+rem;
            n=n/10;
        }
        if(n>100 && temp==rev)
        Console.WriteLine("yes");
        else
        Console.WriteLine("no");
    }
}
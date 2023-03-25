/*
Checking Divisibility By 7 and 3

Write a program to find whether a given number is divisible by both 7 and 3.

Input Format:

Input consists of a single integer.

Output Format:

Output consists of a single line. Refer sample output for the format.

Sample Input 1:

21

Sample Output 1 :

21 is divisible by both 7 and 3

Sample Input 2:

18

Sample Output 2:

18 is not divisible by both 7 and 3
*/
using System;
class Program{
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        if((n%7==0)&&(n%3==0)){
            Console.WriteLine(n+" is divisible by both 7 and 3");
        }
        else{
            Console.WriteLine(n+" is not divisible by both 7 and 3");
        }
    }
}
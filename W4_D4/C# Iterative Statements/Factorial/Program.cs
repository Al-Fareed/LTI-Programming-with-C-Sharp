/*
Factorial Calculation
Write a program to find the factorial of a given number.
Input Format:
Input consists of a single integer, n.
Output Format:
Output consists of a single integer which corresponds to n!
Sample Input 1:
4
Sample Output 1:
24
Sample Input 2:
6
Sample Output 2:
720
*/
using System;
class Program{
    static int fact(int n){
        while(n>0){
            return n*fact(n-1);
        }
        return 1;
    }
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(fact(n));
    }
}
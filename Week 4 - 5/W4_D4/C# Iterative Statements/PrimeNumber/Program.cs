/*
Finding Prime Number

Write a program to find whether a given number is prime or not.


Input Format:

Input consists of a single integer.

Output Format:

The output should display whether the input is “Prime” or “Not prime”.
Refer sample input and output for formatting specifications.


Sample Input 1:
13
Sample Output1:
Prime


Sample Input 2:
33
Sample Output2:
Not prime
*/
using System;
class Program{
    static void Main(){
        int n = int.Parse(Console.ReadLine());
        bool isPrime = false;
        for(int i = 3; i < n; i++){
            if(n%i==0){
                isPrime=false;
                break;
            }else{
                isPrime=true;
            }
        }
        if(isPrime){
            Console.WriteLine("Prime");
        }else{
            Console.WriteLine("Not prime");
        }
    }
}
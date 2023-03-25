/*
Maximum of Three Numbers

Write a  program to find the maximum of three numbers.

Input Format:

Input consists of three lines. Each line consists of an integer.

Output Format:

The output consists of a single line, with the value of a maximum number.

Sample Input 1:

3

5

1

Sample Output 1:

5 is the maximum number

Sample Input 2:

20

60

80

Sample Output 2:

80 is the maximum number
*/
using System;
class Program{
    static void Main(string[] args)
    {
        int a=int.Parse(Console.ReadLine());
        int b=int.Parse(Console.ReadLine());
        int c=int.Parse(Console.ReadLine());
        int max;
        if(a>b){
            if(a>c){
                max=a;
            }else{
                max=c;
            }
        }else{
            if(b>c){
                max=b;
            }else{
                max=c;
            }
        }
        Console.WriteLine(max+" is the maximum number");
    }
}
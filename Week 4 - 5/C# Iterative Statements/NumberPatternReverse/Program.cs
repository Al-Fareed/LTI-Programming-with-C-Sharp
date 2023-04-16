/*
Number Pattern - Reverse
Write a program to print the given pattern.
Input Format:
Input consists of a single integer.
Output Format:
Refer sample outputs. There is a trailing space at the end of each line.

Sample Input:

5

Sample Output:

5 4 3 2 1
4 3 2 1
3 2 1
2 1
1
*/
using System;
class Program
{
    static void Main()
    {
        int n=int.Parse(Console.ReadLine());
        int m=n;
        for(int i=0;i<n;i++)
        {
            for(int j=m;j>0;j--){
                Console.Write(j+" ");
            }
            m--;
                Console.WriteLine();
        }
    }
}
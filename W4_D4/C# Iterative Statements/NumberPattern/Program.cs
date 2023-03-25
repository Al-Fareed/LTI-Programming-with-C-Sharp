/*
Number Pattern
Write a program to print the given pattern.
Input Format:
Input consists of a single integer.
Output Format:
Refer sample outputs. There is a trailing space at the end of each line.

Sample Input 1:  
5
Sample Output 1:

1 2 3 4 5
1 2 3 4
1 2 3
1 2
1
 

Sample Input 2:
3
Sample Output 2:

1 2 3
1 2
1

*/
using System;
class Program{
    static void Main(){
        int n=int.Parse(Console.ReadLine());
        int j;
        for(int i=0;i<n;i++){
            for(j=i;j<n;j++){
                Console.WriteLine(j+" ");
            }
            j--;
        }
    }
}

// Try this optimized code
/*
using System;

class Program {
    static void Main() {
        int n = int.Parse(Console.ReadLine());
        for(int i = 1; i <= n; i++){
            for(int j = 1; j <= n-i+1; j++){
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}

*/
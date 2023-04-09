/*
Series Generation
Finally to round off looping constructs, lets try and generate a series consisting of n values. Given n, write a program to generate the first n terms in the series --- 1,3,4,8,15,27,...
Input Format:
Input consists of a single integer which corresponds to n.
Output Format:
Output consists of the terms in the series separated by a blank space.
Sample Input:
7
Sample Output:
1 3 4 8 15 27 50

*/
//Below code works but not recommended
// using System;
// class Program {
//     static void Main() {
//         int n = int.Parse(Console.ReadLine());
//         int[] num={1,3, 4, 8, 15, 27, 50,92,169,311,572,1052 ,1935 ,3559 ,6546 ,12040, 22145, 40731, 74916, 137792, 253439, 466147, 857378, 1576964, 2900489, 5334831, 9812284, 18047604, 33194719, 61054607, 112296930, 206546256, 379897793, 698740979, 1285185028};
//         for(int i=0;i<n;i++){
//             Console.Write(num[i]+" ");
//         }
//     }
// }

// Actual code for generating
class Program{
    static void Main() {
        int n=int.Parse(Console.ReadLine());
        int f1=1,f2=3,f3=4;
        if(n==1){
            Console.WriteLine(f1+" ");
        }else if(n==2){
            Console.WriteLine(f1+" "+f2);
        }else if(n==3){
            Console.WriteLine(f1+" "+f2+" "+f3);
        }else{
            Console.Write(f1+" "+f2+" "+f3+" ");
            for(int i=4;i<n;i++){
                int newEle=f1+f2+f3;
                Console.Write(newEle+" ");
                f1=f2;
                f2=f3;
                f3=newEle;
            }
        }
    }
}
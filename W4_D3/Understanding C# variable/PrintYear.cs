/*
                                Print Year
Any Project / Automation / Algorithm would read a set of inputs, apply a logical set of steps (on input) and display a set of outputs (End result). Lets start to obtain inputs and display outputs in C#.

Write a program to get current year as input and display the output message.

Create the main class with the name "Program".
Input and Output Format:
Refer sample input and output for formatting specifications.
[All text in bold corresponds to input and the rest corresponds to output]
Sample Input and Output 1 :
Enter current year :
2015
C# was created in the year 2006. I am reading C# in the year 2015
 
Sample Input and Output 2 :
Enter current year :
2020
C# was created in the year 2006. I am reading C# in the year 2020
*/

   using System;
   class Program{
       static void Main(String[] args){
           Console.WriteLine("Enter current year :");
           string year=Console.ReadLine();
           Console.WriteLine("C# was created in the year 2006. I am reading C# in the year "+year);
       }
   }
/*

1
2
3
4
5
Problem

Filter Names using LINQ
Mithra wanted to name her new born kid. She was very particular to name her kid only according the numerologist’s opinion.She had already selected few names.Numerologist suggest her the number,characters count in the name should be below this number. Help her to find the names in which character count is below that number. Write a C# program to filter the name.

Create a class UserProgramCode with static method string[] FilterArray(string[] nameList, int minLength).
FilterArray - Method that accept string array as argument then filter the strings which length is less than given input. Return the processed string array.

Create a class Program read the string array and length from the numerologist then call the static method which is present in UserProgramCode class.

Constrains : Use Linq for filter string array.

Input and Output Format :
Refer sample input and output for formatting specifications. 
If no names present in the given minimum size then display “No names present in the minimum size x”.
All text in bold corresponds to input and rest corresponds to output.  

Sample Input And Output 1: 
Enter the number of names
5
Enter the names
Abi
Aaliyah
Sarika
Vandhana
Vera
Enter the min string size
6
Filtered Names
Abi
Vera

Sample Input And Output 2: 
Enter the number of names
3
Enter the names
Divyadharshini
Haveenna
Anathapriyadharshini
Enter the min string size
5
No names present in the minimum size 5

Program
*/
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        UserProgram userProg = new UserProgram();

        Console.WriteLine("Enter the number of names");
        int noOfNames = int.Parse(Console.ReadLine());
        string[] names = new string[noOfNames];
        Console.WriteLine("Enter the names");
        for (int i = 0; i < noOfNames; i++)
        {
            names[i] = Console.ReadLine();
        }
        Console.WriteLine("Enter the min string size");
        int minSize = int.Parse(Console.ReadLine());
        string[] filteredNames = UserProgram.FilterArray(names, minSize);
        if (filteredNames.Length > 0)
        {
            Console.WriteLine("Filtered Names");
            foreach (string item in filteredNames)
            {
                Console.WriteLine(item);
            }
        }
        else{
            Console.WriteLine("No names present in the minimum size "+minSize);
        }
    }
}
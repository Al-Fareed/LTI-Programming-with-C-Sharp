
/*
Write a program to check whether a given year is a leap year or not.
Input Format:
Input consists of a single integer.
Output Format:
The output consists of a single line. Refer to sample output for details.
Sample Input 1:
1988
Sample Output 1:
1988 is a leap year
Sample Input 2:
1994
Sample Output 2:
1994 is not a leap year
Hint:
In general terms, the algorithm for calculating a leap year is as follows...
A year will be a leap year if it is divisible by 4 but not by 100. If a year is divisible by 4 and by 100, it is not a leap year unless it is also divisible by 400.
Thus years such as 1996, 1992, 1988, and so on are leap years because they are divisible by 4 but not by 100.
For century years, the 400 rule is important. Thus, century years 1900, 1800 and 1700 while all still divisible by 4 are also exactly divisible by 100. As they are not further divisible by 400, they are not leap-years.
*/

 // Effective and Optimized way
using System;
class Program{
    static void Main(){
        int year=int.Parse(Console.ReadLine());
          bool leap=(year%4==0 || (year%100!=0 && year%400==0))?leap=true:leap=false;
        if(leap){
                Console.WriteLine(year+" is a leap year");
        }else{

            Console.WriteLine(year+" is not a leap year");
        }
    }
}


/*Another way to solve*/
/*class Program{
    static void Main(){
        int year=int.Parse(Console.ReadLine());
         if(year%4==0){
            if(year%100!=0){
                Console.WriteLine(year+" is a leap year");
                return;
            }
         }
        if(year%4==0){
            if(year%100==0 && year%400==0){
                Console.WriteLine(year+" is a leap year");
            }else{
                Console.WriteLine(year+" is not a leap year");
            }
        }else{

            Console.WriteLine(year+" is not a leap year");
        }
    }
}

// Simplified than before
class Program{
    static void Main(){
        int year=int.Parse(Console.ReadLine());
        bool leap=false;
        if(year%4==0){
            if(year%100!=0){
                leap=true;
            }else if(year%400==0){
                leap=true;
            }
        }
        if(leap){
            Console.WriteLine(year+" is a leap year");
        }else{
            Console.WriteLine(year+" is not a leap year");
        }
    }
}
*/
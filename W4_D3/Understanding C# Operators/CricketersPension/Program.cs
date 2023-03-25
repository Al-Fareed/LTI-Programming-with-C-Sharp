/*
Cricketer's Pension
Continuing our journey in mastering the conditional statements & our interest with cricket. Lets help the Indian cricket's governing body (BCCI) to automate its plan of alloting pensions to former players. The rules are given below:

 
If a player has played more than 10 test matches and 100 ODI's he receives Rs.50,000.
If a player has played more than 10 test matches he receives Rs.25,000.
If a player has played more than 100 ODI's he receives Rs.15,000.
If a player has played for India he receives Rs.10,000.
 
The amount is incremented by 1/4th for every 'man of the match' award.
 
If a player has not played for India but played IPL he receives an amount of Rs.8,000.
If a player has not played for India nor IPL he receives an amount of Rs.7,000.
Create a main class with the name "Program".
 
 
Input and Output Format:
 
Refer sample input and output for formatting specifications. 
 
[All text in bold corresponds to input and the rest corresponds to output] 
 
Sample Input and Output 1:
Has the player represented for India[y or n]?
y
Enter the number of Test matches he has played
15
Enter the number of ODI matches he has played
101 
Number of man of the matches he has won
2
Amount received as pension: Rs.75000.0
 
Sample Input and Output 2:
Has the player represented for India[y or n]?
n 
Has he played IPL[y or n]?
y
Amount received as pension: Rs.8000.0
*/
using System;
class Program{
    static void Main(){
        Console.WriteLine("Has the player represented for India[y or n]?");
        char rep=char.Parse(Console.ReadLine());
        double pension=0;
        if(rep=='y'){
            Console.WriteLine("Enter the number of Test matches he has played");
            int nTest=int.Parse(Console.ReadLine()); //15
            Console.WriteLine("Enter the number of ODI matches he has played");
            int nODI=int.Parse(Console.ReadLine()); //101
            Console.WriteLine("Number of man of the matches he has won");
            int nMOM=int.Parse(Console.ReadLine()); //2
            if(nTest>10 && nODI>100){
                pension+=50000;
            }
            else if(nTest>10){
                pension+=25000;
            }
            else if(nODI>100){
                pension+=15000;
            }else{
                pension+=10000;
            }
            pension =(pension+(0.25*pension)*nMOM); 
        }else{
            Console.WriteLine("Has he played IPL[y or n]?");
            rep=char.Parse(Console.ReadLine());
            if(rep=='y'){
                pension+=8000;
            }else{
                pension+=7000;
            }
        }
        Console.WriteLine("Amount received as pension: Rs."+String.Format("{0:0.0}",pension));
    }
}
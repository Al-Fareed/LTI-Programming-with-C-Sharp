/*
Carrom
 
If Cricket is the most popular outdoor game in India, Carrom is not too behind as one of most played indoor games.
Lets make use of our knowledge in operators & conditional statements  to compute the points scored at the end of a round.
Carrom is a board game where two participants (teams) play. It consists of 9 white coins, 9 black coins and a red coin. The first team that finishes all their coins wins (given that red has been pocketed by one of the teams). The points are awarded based on the number of left-over coins of the opposition (loser) in the board  . If the winning team has pocketed the red, they get an additional 5 points. Write a program to compute the score of winner at the end of a round.
Create a main class with the name "Program".
Input Format:
Input consists of a single integer which corresponds to number of coins left on board and a character which corresponds to whether the winning team has pocketed red or not.
Output Format:
Output corresponds to the total points won.
[All text in bold corresponds to input and the rest corresponds to output] 
Sample Input 1:
Enter number of lost team's coins left on board
5
Has winning team pocketed red [y or n] ?
y
Sample Output 1:
Points won : 10
Sample Input 2:
Enter number of lost team's coins left on board
-1
Sample Output 2:
Invalid Input 
*/
using System;
class Program{
    
    static void Main(){
        try{
            Console.WriteLine("Enter number of lost team's coins left on board");
            string input=Console.ReadLine();
            bool flag=true;
            if(string.IsNullOrEmpty(input)){
                flag=false;
                throw new Exception();
            }else{
                int num=int.Parse(input);
                if(num<=0||num>9){
                    throw new Exception();           
                }
                else{
                    if(flag){
                        Console.WriteLine("Has winning team pocketed red [y or n] ?");
                    int points=num;
                    char ch=char.Parse(Console.ReadLine());
                    if(ch=='y'){
                        points+=5;
                    }
                    Console.WriteLine("Points won : "+points);
                    }
                }
            }
        }catch(System.Exception){
                Console.WriteLine("Invalid Input");
        }
    }
}
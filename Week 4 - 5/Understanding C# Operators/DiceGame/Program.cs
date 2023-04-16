/*
Dice Game 
 
As you are mastering the looping constructs, one of your friends' uncle who owns a casino is struck with a problem. He wants to quickly calculate the amount a player would receive while he finishes the game. You would want to help him as well as get couple of free chances in the casino. Show your expertise. (use a do-while construct)
 The rules are as follows:

A player can enter the game with minimum amount of 1000.
A player can take any number of chances. If the value of the dice is '1', the player leaves the game with half the amount. If the value is other than '1', the total amount is raised by multiple of 100*value of dice.
If the player quits,he/she leaves the game with amount he/she has got.

Input consists of 1 float values denotes the amount and 1 integer which is the values of dice and a char which denotes "y" or "n".
The value of dice must be between (0>n>=6).
Create a main class with the name "Program".
Input and Output Format:
Refer sample input and output for formatting specifications. 
 
[All text in bold corresponds to input and the rest corresponds to output] 
 
Sample Input and Output 1:
 
Enter the amount you are entering the game with:
15000
Value of dice
8
Invalid value
Please enter a valid value
Value of dice
3
Do you continue[y or n]?
y
Value of dice
 
Invalid value
Please enter a valid value
Value of dice
2
Do you continue[y or n]?
n
Amount received while leaving the game 15500
 
Sample Input and Output 2:
 
Enter the amount you are entering the game with:
950
You cannot enter the game with this money

*/
using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the amount you are entering the game with:");
        int amount = int.Parse(Console.ReadLine());
        if(amount>1000){
            char ch='y';
            do{
                Console.WriteLine("Value of dice");
                int value=int.Parse(Console.ReadLine());
                if(value==1){
                        amount=amount/2;
                        Console.WriteLine("Amount received while leaving the game "+amount);
                        break;
                }
                else if(value>1 && value<7 ){
                        amount=amount+(value*100);
                        Console.WriteLine("Do you continue[y or n]?");
                        ch=Console.ReadLine()[0];
                }else{
                    Console.WriteLine("Invalid value\nPlease enter a valid value");
                }
            }while(ch=='y');
            Console.WriteLine("Amount received while leaving the game "+amount);
        }else{
            Console.WriteLine("You cannot enter the game with this money");
        }
    }
}
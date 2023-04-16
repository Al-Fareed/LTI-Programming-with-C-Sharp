/*
Lambda Expressions

There is fight between the two kingdom,you are one of the soldier in Alexander the Great kingdom.He gives you the coins to fight with your enemies.If you dont have sufficient coins to fight get from the king and while you attack them you will tend to lose your coins for each of your defeat.You are confused about the remaining coins you are having hence write a C# program to calculate how many coins you are having at the end of the war.Therefore, you will have two options,one is getting point the the king and another is attack them.The last output will be the remaining coins you have.

Write a C# program to play a game with two operations,Collect coins and Attack Enemies,using Lambda expression.

Create a class Soldier with the following data members and member functions:

Data Members:
_soldierNumber - of type string
_coins - of type int
and a constructor to initialize the data members.

Member Function:
public void Playgame(Lambda Expression,int coins)

Create two lambda expressions for Collect coins and Attack Enemies.These expression accepts two attributes, soldier object, and coins.The functionality of lamda expressions are given below

    collect_coins- adds the coins to the balance of soldier object
    attack_enemies-subtracts the coins from the balance of soldier object


Create a class Program to include the Main method. In the main method call the Playgame method with lambda expressions.

Sample Input and Output:

Enter Soldier Number :
Sol001
Enter Initial coins :
2000
1. Collect Coins
2. Attack Enemies
3. End war
1
Enter Coins :
1000
1. Collect Coins
2. Attack Enemies
3. End war
1
Enter Coins :
500
1. Collect Coins
2. Attack Enemies
3. End war
2
Enter Coins :
500
1. Collect Coins
2. Attack Enemies
3. End war
3
Balance coins for next war: 3000
*/
using System;
public delegate void warActionDelegate(int coins);
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Soldier Number :");
        string soldierNumber = Console.ReadLine();
        Console.WriteLine("Enter Initial coins :");
        int initialCoins = int.Parse(Console.ReadLine());
        Soldier soldier = new Soldier(soldierNumber, initialCoins);
        int ch;
        do
        {
            Console.WriteLine("1. Collect Coins\n2. Attack Enemies\n3. End war");
            ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Coins :");
                    int collectCoins = int.Parse(Console.ReadLine());
                    warActionDelegate cd = (coins) =>
                    {
                        soldier.Coins += collectCoins;
                    };
                    cd.Invoke(collectCoins);
                    break;
                case 2:
                    Console.WriteLine("Enter Coins :");
                    int attackCoins = int.Parse(Console.ReadLine());
                    warActionDelegate ad = (coins) =>
                    {
                        soldier.Coins -= attackCoins;
                    };
                    ad.Invoke(attackCoins);
                    break;
                case 3:
                    Console.WriteLine("Balance coins for next war:" + soldier.Coins);
                    return;
            }
        } while (ch != 3);

    }
}
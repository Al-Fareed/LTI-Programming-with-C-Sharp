using System;
public class Soldier
{
    private string _soldierNumber;
    private int _coins;
    public int Coins{
        get=>_coins;
        set => _coins = value;
    }
    public string SoldierNumber{
        get => _soldierNumber;
    }
    public Soldier(string soldierNumber, int coins)
    {
        _soldierNumber = soldierNumber;
        _coins = coins;
    }
    public void collectCoins(int coins){
        _coins +=coins; 
    }
    public void attack(int coins){
        _coins -= coins;
    }
}
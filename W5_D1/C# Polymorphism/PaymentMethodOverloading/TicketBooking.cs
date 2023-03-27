using System;
public class TicketBooking
{
    public TicketBooking(){}

    public void MakePayment(double amount){
        Console.WriteLine("You have selected the Cash payment mode\nThe Amount is Rs.{0}.",amount);
    }
    public void MakePayment(string walletNumber, double amount){
        Console.WriteLine("You have selected the Wallet payment mode\nWallet Number: {0}\nThe Amount is Rs.{1}.",walletNumber,amount);

    }
    public void MakePayment(string creditCard, string ccv, string name, double amount){
        System.Console.WriteLine("You have selected the Credit Card payment mode\nCreditCard Number: {0}\nValidity Date: {1}\nCard Holder Name: {2}\nThe Amount is Rs.{3}.",creditCard,ccv,name,amount);
    }
}
using System;
class Program{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter temparature in Celcius");
        int temp=int.Parse(Console.ReadLine());
        float fah=( temp * 95 ) + 32;
        Console.WriteLine("The equivalent Temparature in Fahrenheit is "+String.Format("{0:0.0}F",fah));
    }
}




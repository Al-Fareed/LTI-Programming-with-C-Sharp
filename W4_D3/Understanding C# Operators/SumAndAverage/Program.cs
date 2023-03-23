using System;
class Program{
    static void Main(string[] args){
        Console.WriteLine("Enter the count");
        int count= int.Parse(Console.ReadLine());
        double sum=0;
        if(count>0){
            Console.WriteLine("Enter numbers");
        for(int i=0;i<count;i++){
            double num=double.Parse(Console.ReadLine());
            sum=sum+num;
        }
        double avg=(double)(sum/count);
        Console.Write("Sum of numbers is "+String.Format("{0:0.0}",sum));
        Console.WriteLine(" average of numbers is "+String.Format("{0:0.0}",avg));
        }
        else{
            Console.WriteLine("Invalid Input");
        }
    }
}   
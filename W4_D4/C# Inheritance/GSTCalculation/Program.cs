using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter event name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter the cost per day");
        double cost = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of days");
        int days = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the type of event\n1.Exhibition\n2.Stage Event");
        string type = Console.ReadLine();
        if (type == "1")
        {
            Console.WriteLine("Enter the number of stalls");
            int stalls = int.Parse(Console.ReadLine());
            Exhibition e=new Exhibition(name,"Exhibition",cost,days,stalls);
            Console.WriteLine("Event Details");
            e.ToString();

        }
        else if (type == "2")
        {
            Console.WriteLine("Enter the number of seats");
            int seats = int.Parse(Console.ReadLine());
            StageEvent s=new StageEvent(name,"Stage Event",cost,days,seats);
            Console.WriteLine("Event Details");
            s.ToString();

        }
        else
        {
            Console.WriteLine("Invalid input");
        }

    }
}
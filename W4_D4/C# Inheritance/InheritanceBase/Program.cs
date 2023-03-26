using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the Event Name:");
        //Fill your code
        Console.WriteLine("Enter the Event Date:");
        //Fill your code
        Console.WriteLine("Enter the Event Organizer:");
        //Fill your code
        Console.WriteLine("Enter the Event Type(Exhibition/Stage Event):");
        string eType = Console.ReadLine();

		if(eType == "Exhibition")
		{
			Console.WriteLine("Enter the Stall Type:");
			//Fill your code
		}
		else if(eType == "Stage Event")
		{
			Console.WriteLine("Enter the Show Type:");
			//Fill your code
		}
		else
		{
			Console.WriteLine("Enter the correct Event Type and try again...");
		}
    }
}

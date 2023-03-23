/*
Flight Details

Let us master the various data types by writing a program to obtain various data values from user and displaying it in different formats. This would give us the confidence to obtain data in any format, convert it in our needs and display it back.  Use the various data types to collect flight details. 

Create a main class with the name "Program".

Input and Output Format:
Refer sample input and output for formatting specifications. 
 
[All text in bold corresponds to input and the rest corresponds to output] 
 
Sample Input and Output : 
Enter Flight name :
Emirates
Enter Ticket No :
43190215
Enter Flight Fare :
19433.94
Enter Traveling Class :
C
Enter Source :
Mumbai
Enter Destination :
Dubai
Flight Details : 
Flight Name : Emirates
Ticket No : 43190215
Flight Fare : 19433.94
Class : C
Source : Mumbai
Destination : Dubai
*/
using System;
class Program {
  static void Main() {
        Console.WriteLine("Enter Flight name :");
        string fname=Console.ReadLine();
        Console.WriteLine("Enter Ticket No :");
        long ticket=long.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Flight Fare :");;
        double fare=double.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter Travelling Class :");
        string travelingClass=Console.ReadLine();
        System.Console.WriteLine("Enter Source :");
        string source=Console.ReadLine();
        System.Console.WriteLine("Enter Destination :");
        string destination=Console.ReadLine();
        Console.WriteLine("Flight Details :");
        System.Console.WriteLine("Flight Name : {0}\nTicket No : {1}\nFlight Fare : {2}\nClass : {3}\nSource : {4}\nDestination : {5} ",fname,ticket,fare,travelingClass,source,destination);
  }
}
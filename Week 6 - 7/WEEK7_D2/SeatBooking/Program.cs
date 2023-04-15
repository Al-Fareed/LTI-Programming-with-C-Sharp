/*
Seat Booking
Write a program to book the seat and display the result.

 

[Note : Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider class SeatNotAvailableException which extends Exception class.
Include a constructor with a string argument "Message", pass the Message to the base class constructor.

Consider Program class with Main method, get the details of the availability of seats from the user and the seat number for booking.
Use try catch block to catch the exception and display the error message.
If the seat is available, display success message as “Booked successfully”. If the seat is already booked then display “Seat booked already”.

Note: In the seat availability string, 0 indicates the seat is available whereas 1 indicates the booked seat.

The link to download the template code is given below
Code Template


Input and Output Format:
Refer sample input and output for formatting specifications.
[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input and Output 1 :
Enter the booking details
001001
Enter the seat number to book
2
Booked successfully

Sample Input and Output 2 :
Enter the booking details
101001
Enter the seat number to book
3
Seat booked already

Sample Input and Output 3 :
Enter the booking details
1001100
Enter the seat number to book
8
Array index is out of range.
*/
using System;
class Program : Exception
{
    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the booking details");
            string seatDet = Console.ReadLine();
            char[] seatDetails = seatDet.ToCharArray();
            Console.WriteLine("Enter the seat number to book");
            int seatNo = int.Parse(Console.ReadLine());
            seatNo--;
            if (seatNo < seatDetails.Length)
            {
                if (seatDetails[seatNo ] == '1')
                {
                    throw new SeatNotAvailableException("Seat booked already");
                }
                else
                {
                    Console.WriteLine("Booked Successfully");
                }
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }
        catch (SeatNotAvailableException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(IndexOutOfRangeException){
            Console.WriteLine("Array index is out of range.");
        }
    }
}
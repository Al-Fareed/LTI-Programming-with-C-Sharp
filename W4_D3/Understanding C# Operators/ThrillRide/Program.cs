/*
Thrill ride
"Zebra Kingdom" is a brand new Amusement park that is going to be inaugurated shortly in the City and is promoted as the place for breath-taking charm. The theme park has more than 30 exhilarating and thrilling rides and as a special feature of the park, the park Authorities have placed many Booking Kiosks at the entrance which would facilitate the public to purchase their entrance tickets and ride tickets.

There are few rides in the park that are not suitable for children and aged people, hence the park Authorities wanted to program the kiosks to issue the tickets based on people’s age. If the age given is less than 15 (Children) or greater than 60 (Aged), then the system should display as "Not Allowed", otherwise it should display as "Allowed".

Write a program to implement this functionality.

Input Format:

The first line of the input is an integer that corresponds to the age of the person opting for the ride.

Output Format:

The output should display "Allowed" or "Not Allowed" based on the conditions given.
Refer sample input and output for formatting specifications.

Sample Input 1:

20

Sample Output 1:

Allowed

Explanation:

20 is greater than 15, so the output is “Allowed”

Sample Input 2:

12

Sample Output 2:

Not Allowed

Explanation:

12 is less than 15, so the output is “Not Allowed”
*/
using System;
public class Program{
    static void Main(){
        int age=int.Parse(Console.ReadLine());
        if(age<15 || age>60){
            Console.WriteLine("Not Allowed");
        }else{
            Console.WriteLine("Allowed");
        }
    }
}
/*
Compare Phone Number
 
The “Traveller” New App helps you discover great places to eat around or de-stress in all major cities. The app allows you to explore restaurants, spa & salons, and activities to find your next fantastic deal. To use services of the app the user have to create an account. No two users are allowed to have the same phone number. Write a program to find the duplication of user accounts.
 
Write a C# program to get two users details and display whether their phone numbers are same or not with the following classes and methods.

[Note : Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]
 

Consider the class User with the following private attributes/variables.

Data type	Attributes
string	_name
string	_username
string	_password
long	_phoneNumber
 

Include appropriate getters and setters.
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor is User(string _name,string _username,string _password,long _phoneNumber)

Define the following method in the User class.

Method Name  	Description
public bool ComparePhoneNumber(User user)	In this method, compare the phone number of the two users and return true if both the numbers are equal else return false.

Create another class Program and write a Main method to test the above class.

In the main method

    Obtain the details of the user.
    Create an object for the User class using the parameterized constructor(name, username, password, phoneNumber).
    Call the method ComparePhoneNumber() in the Main class.
 

The link to download the template code is given below
Code Template

 

Input and Output Format
Refer sample input and output for formatting specifications.

If both phone numbers are the same then print “Same Users” else print “Different Users”.
The output should be printed in the Main class.


[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input and Output 1:

Enter Name
john
Enter UserName
john@123
Enter Password
john@123
Enter PhoneNumber
9092314562
Enter Name
john
Enter UserName
john@12
Enter Password
john@12
Enter PhoneNumber
9092314562
Same Users

Sample Input and Output 2:

Enter Name
william
Enter UserName
william####
Enter Password
william
Enter PhoneNumber
9092314562
Enter Name
john
Enter UserName
john@123
Enter Password
john@123
Enter PhoneNumber
9092312102
Different Users
*/
using System;
class Program
{
    static void Main(string[] args)
    {
        User[] u = new User[2];
        for (int i = 0; i < 2; i++)
        {
            u[i] = new User();
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter UserName");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber");
            long phoneNumber = long.Parse(Console.ReadLine());
            u[i] = new User(name, userName, password, phoneNumber);
        }
        if(u[0].ComparePhoneNumber(u[1])){
            Console.WriteLine("Same Users");
        }else{
            Console.WriteLine("Different Users");
        }
    }
}
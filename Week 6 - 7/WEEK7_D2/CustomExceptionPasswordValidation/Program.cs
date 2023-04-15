/*
Custom Exception - Password Validation
Create a class User with following attributes 
Data Type	Variables
string	_firstName
string	_lastName
string	_email
string	_password
Include appropriate Properties.
Include four-argument constructor with parameters in the following order,
public User(string _firstName,string _lastName,string _email,string _password)

Create another class UserBO with the following method, 
Method	Description
 static void validatePassword(string password)	In this method, password id is validated throws WeakException if the password is not in the correct format.

Password rules:
It should be minimum of 10 characters and maximum of 20 characters.
It should contain atleast one digit.

It should contain atleast one special character (non-numeric, non-alphabetic).

If the password doesnt match with the rule then throw the exception "WeakPasswordException"

*/
using System;
public class WeakException : Exception
{
    public WeakException(string message) : base(message)
    {
    }
}
class Program : Exception
{
    static void Main(string[] args){
        try{
            Console.WriteLine("Enter First Name:");
            string fName = Console.ReadLine();
            Console.WriteLine("Enter Last Name:");
            string lName = Console.ReadLine();
            Console.WriteLine("Enter E-Mail:");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Password:");
            string password = Console.ReadLine();
            UserBo.validatePassword(password);
            User user =  new User(fName,lName,email,password);
            user.Display();
        }
        catch(WeakException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

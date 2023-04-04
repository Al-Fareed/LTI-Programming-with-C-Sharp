/*
Display Customer Details

Write C# program to display the customer names using delegates.

 

[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

 

Consider Program class with Main method, get the customer names and display using delegate method.

Create a delegate method named delegate void NameDelegate() in Program class.

Consider a class named Customer with the following public attributes

Data Type	Attribute
string	_firstName
string	_lastName
 

The methods for constructor is given in the template code.

Define the following methods in Customer class 

Method Name	Description
void DisplayFirstName()	This method is used to display the customer first name. For eg: “First Name: John”
void DisplayLastName()	This method is used to display the customer last name. For eg: “Last Name: Smith”
 

Consider the class Program. It includes the method Main.
In the Main method,

read the customer details from the user, create a reference to the customer and invoke delegate methods to display the customer names.
 

The link to download the template code is given below
Code Template


Input and Output Format :

Display the “Customer Details” in main method.

Refer sample input and output for formatting specifications. 

[All text in bold corresponds to input and rest corresponds to output.]

Sample Input And Output 1:

Enter the first name:
John
Enter the last name:
Smith
Customer Details
First Name: John
Last Name: Smith

 
*/
using System;
public delegate void NameDelgate();
class Program{
    static void Main(){
        Console.WriteLine("Enter the first name:");
        string fname = Console.ReadLine();
        Console.WriteLine("Enter the last name:");
        string lname = Console.ReadLine();
        Customer c = new Customer(fname,lname);
        NameDelgate nd = new NameDelgate(c.DisplayFirstName);
        nd += c.DisplayLastName;
        Console.WriteLine("Customer Details");
        nd.Invoke();

    }
}
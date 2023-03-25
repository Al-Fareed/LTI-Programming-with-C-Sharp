/*
Getter and Setter Implementation

A system needs to be designed for the purpose of generating phone bills considering certain creteria such as tariff plans,type of connection and plans etc.,. The system is enclosed with various classes such as customer , address, bills, phone calls and tariffs. Each class has its own characteristics and certain function to possess their operations in order to make the classes interrelate with other classes and provide relationship between the classes if required. In order to implement the system let us start by creating a class called 'Customer' and add the mentioned data members.

Obtain the customer details and display the obtained details using getters and setters.

Create a class called Customer with the following member variables

Data Type	Variable Name
int	_id
string	_name
string	_email
string	_address
string	_purpose
string	_otherDetails

Methods in Customer Class

Include appropriate properties (Getters and Setter) like Id,Name,Email,Address,Purpose,OtherDetails.
Include the method Display() which can display the customer details.

Create a Program class to include the Main method.
In the Main method
Obtain the details of the customer and assign the values to the properties (getters,setters) in Customer class(For example: object.Name)
Create an object for Customer class
Call the method Display() in Customer class
Note :
Strictly adhere to the object oriented specifications given as a part of the problem statement.
Use the same class names and member variable names.
 

[All text in bold are input and the remaining are output] 
Sample Input and Output 1:

Enter the customer details
Enter the  id :
1
Enter the name :
Williams
Enter the email :
williams@redif.in
Enter the address :
2/7,White street,Eslectronic city 1,bangalore-01
Enter the purpose :
Commercial
Enter the other customer details :
NIL


Customer details are :
ID :1
Name :Williams
Email :williams@redif.in
Address :2/7,White street,Electronic city 1,bangalore-01
Purpose :Commercial
Other details :NIL

[All text in bold are input and the remaining are output] 
Sample Input and Output 2:
Enter the customer details
Enter the  id :
2
Enter the name :
Hari
Enter the email :
hari@gmail.com
Enter the address :
23,gopal nagar,golden city,cbe-01
Enter the purpose :
domestic
Enter the other customer details :
this customer is limited to bandwidth usage


Customer details are :
ID :2
Name :Hari
Email :hari@gmail.com
Address :23,gopal nagar,golden city,cbe-01
Purpose :domestic
Other details :this customer is limited to bandwidth usage
*/
using System;
class Program{
    static void Main(){
        Console.WriteLine("Enter the customer details\nEnter the  id :");
        int id=int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the name :");
        string name=Console.ReadLine();
        Console.WriteLine("Enter the email :");
        string email=Console.ReadLine();
        Console.WriteLine("Enter the address :");
        string address=Console.ReadLine();
        Console.WriteLine("Enter the purpose :");
        string purpose=Console.ReadLine();
        Console.WriteLine("Enter the other customer details :");
        string other=Console.ReadLine();
        Customer c=new Customer();
        c.Id=id;
        c.Name=name;
        c.Email=email;
        c.Address=address;
        c.Purpose=purpose;
        c.OtherDetails=other;
        c.Display();
    }
}
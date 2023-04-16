/*
File Handling
[Note :
Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create class Address with the following private attributes/variables.
Data Type	Variable
string    	_addressLine1
string    	_addressLine2
string    	_city
string    	_state
int    	_pincode

Include appropriate properties.
Include a default constructor and a five argument constructor with parameters in the following order _addressLine1, _addressLine2, _city, _state, _pincode.

Create class AddressBO with the following methods.
Method    	Description
public Address CreateUser(string value)	In this method, create address object using the given value and return it.
public void Display(List<Address> list)	This method is used to display the address details.

Create Program class with Main method to test the above class.
Read the input file using StreamReader.
Read the lines from the input file and create address object by parsing the input. Add all the address object to the List.
Display all the objects in the list in the specified format given below.

Input Format
The input file name must be "input.csv".
The input file consists of a set of address details in comma separated format in the order Address line 1, Address line2, City, State, Pincode.

Output Format:
String.Format("{0,-15} {1,-25} {2,-15} {3,-15} {4,-15}","Address line 1","Address line 2","City","State","Pincode") 

Sample Output :
Address details
Address line 1  Address line 2            City            State           Pincode
6/124           Gandhi street             Pune            Maharashtra     641669
24/159          Nehru street              Darjeeling      West Bengal     641659
No:87           Tri-State area            Danville        San Romon       925669
3/65            S.K street                chennai         Tamil Nadu      601669
No:37           A.P.J Kalam street        Rameshwaram     Tamil Nadu      641890
No:6            Ambethkar street          Mumbai          Maharashtra     641569
1/5             V.J street                Bengaluru       Karnataka       689569
2/51            A.J street                Kolkata         West Bengal     641899
No:69           Kattor street             Ahmedabad       Gujarat         643269
2/203           Bharathiyar street        Hyderabad       Telangana       649269
*/
using System;
using System.IO;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            StreamReader reader = new StreamReader("input.txt");
            string line;
            List<Address> addresses = new List<Address>();
            AddressBO aBO = new AddressBO();
            while((line = reader.ReadLine())!= null)
            {
                // aBO.CreateAddress(line);
                Address address = aBO.CreateAddress(line);
                addresses.Add(address);
            }
            Console.WriteLine("Address details");
            Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-15} {4,-15}","Address line 1","Address line 2","City","State","Pincode");
            aBO.Display(addresses);
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
/*
Sort Address - Comparable
[Note:  
Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create class User with the following private member variables/ attribute which extends Icomparable interface.

Data Type	Variable
string	_name
string	_add1
string	_add2
long	_pincode

Include appropriate properties.
Include a four-argument constructor  with parameters in the following order, 
public User(string _name, string _add1, string _add2, long _pincode)
Override CompareTo() method in User class which compares user details based on pincode. 
Override ToString() method in the User class to return the User details.

Create Program class with Main method, get the number of users and user details from the user.
Sort the user details based on pincode using Comparable Interface.

	If the pincode is same, sort user details based on add1.
Display user details in sorted order.
Input and   Output Format   
Refer sample input and output for formatting specifications. 
All text in bold corresponds to the input and the rest corresponds to output.  

Sample Input And Output  1:
Enter total number of users
3
Enter User Name
James
Enter User Address
Enter Address line 1
45/34
Enter Address line 2
Gandhi Street
Enter Pincode
656456
Enter User Name
Peter
Enter User Address
Enter Address line 1
1/221
Enter Address line 2
Bharathi street
Enter Pincode
626124
Enter User Name
Jones
Enter User Address
Enter Address line 1
2/1546
Enter Address line 2
Anna nagar
Enter Pincode
626124
Name : Peter Address : 1/221,Bharathi street,626124
Name : Jones Address : 2/1546,Anna nagar,626124
Name : James Address : 45/34,Gandhi Street,656456

*/
using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {

        List<User> userList = new List<User>();
        Console.WriteLine("Enter total number of users");
        int noOfUsers = int.Parse(Console.ReadLine());
        for (int i = 0; i < noOfUsers; i++)
        {
            Console.WriteLine("Enter User Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter User Address");
            Console.WriteLine("Enter Address line 1");
            string add1 = Console.ReadLine();

            Console.WriteLine("Enter Address line 2");
            string add2 = Console.ReadLine();

            Console.WriteLine("Enter Pincode");
            long pin = long.Parse(Console.ReadLine());

            User user = new User(name, add1, add2, pin);
            userList.Add(user);
        }
        userList.Sort();

        foreach (User user in userList)
        {
            Console.WriteLine(user.ToString());
        }
    }
}
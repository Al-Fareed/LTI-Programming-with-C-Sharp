/*
IComparer
[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create a class User with the following private member variables/ attribute.
Data Type	Variable
string	_name
string	_email
string	_contactNo

Include appropriate properties.
Include a four-argument constructor  with parameters in the following order, 
public User(string _name,string _email,string _contactNo).

Create a class NameComparator which extends IComparer interface.
Override Compare() method in this class which sorts user based on name.

Create a class EmailComparator which extends IComparer interface.
Override compare() method in thes class which sorts user based on email.

Override ToString() method in the User class to which displays User details specified format.
string.Format("{0,-15}{1,-15}{2,-20}",name,email,contactNo)

Create class Program with Main method, get input details as a comma seperated string in following order
       name,email,contactNo
Sort them based on the given parameter(Name or Email).

Input and   Output Format   
Refer sample input and output for formatting specifications. 
All text in bold corresponds to the input and the rest corresponds to output. 

Sample Input And Output  1:
Enter total number of users
3
Enter User Details
john,john@rediffmail.com,9092304176
o'shea,o'shea@gmail.com,9092415798
peter,peter@yahoo.in,8745129630
Sort By 1]Name 2]Email
1
john           john@rediffmail.com 9092304176
o'shea         o'shea@gmail.com    9092415798
peter          peter@yahoo.in      8745129630

Sample Input And Output  2:
Enter total number of users
2
Enter User Details
arun,larun@gmail.com,9876541230
john,john@yahoo.in,9876541230
Sort By 1]Name 2]Email
2
john           john@yahoo.in       9876541230
arun           larun@gmail.com     9876541230
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1
{
    class Program
    {

        static void Main(string[] args)
        {
            List<User> userList= new List<User>();
            Console.WriteLine("Enter total number of users");
            int noOfUser=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter User Details");
            // fill your code      
            for(int i=0;i<noOfUser;i++){
                string[] details=Console.ReadLine().Split(",");
                User user = new User(details[0],details[1],details[2]);
                userList.Add(user);
            }
            Console.WriteLine("Sort By 1]Name 2]Email");
            int choice=int.Parse(Console.ReadLine());
            if(choice == 1)
                userList.Sort(new NameComparator());
            else 
                userList.Sort(new EmailComparator());

            foreach (User user in userList)
            {
                Console.WriteLine(user.ToString());
            }
        }
    }
}
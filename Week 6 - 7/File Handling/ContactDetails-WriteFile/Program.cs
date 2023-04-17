/*
Contact Details-Write File
[Note :
Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Write a program to read the contact details from the user and write it into a file in csv format.

Create class Contact with the following private attributes/variables.
Data Type	Variable
string	_name
long	_mobile
long	_altMobile
string	_address
string	_email

Include appropriate properties.
Include a five-argument constructor with parameters in the following order,
public Contact(string name,long mobile, long altMobile, string address, string email)

Create class ContactBO with the following methods.
Method	Description
public void AddData(List<Contact> list)	In this method, iterate the list of contact details and write thw unique contacts into a file named "output.csv". 

Create Program class with Main() method, get the contact details as a comma separated values from the user in the following format.
(name,mobile,altMobile,address,email)
Create an object for Contact class with the values given by the user and store the object in the list.
Write the unique contact details into the output file in csv format using StreamWriter Class.
Display that contact is successfully added after adding the unique contacts to the output file.

Note: The Output file should be in the csv format as follows.
(name,mobile,altMobile,address,email)

Input and Output Format
Refer sample input and output for formatting specifications.
All text in bold corresponds to the input and the rest corresponds to output.

Sample Input and Output 1
Enter No of Contacts:
2
Enter the Contact Details
Sahana,7889919957,7332142345,238964,sahana@gmail.com,London
Sahana,7889919957,7332142345,238964,sahana@gmail.com,London
Contact Details Added

Sample Input and Output 2
Enter No of Contacts:
5
Enter the Contact Details
Sandra,9788919957,7334412345,234234,sandra@gmail.com,California
Ferb,9788917657,8734412345,254234,ferb@gmail.com,Chicago
Sahana,7889919957,7332142345,238964,sahana@gmail.com,London
Cassandra,7848919957,9834412345,234267,cassandra@gmail.com,New York
Daniel,9782345957,7334415682,234454,daniel@gmail.com,London
Contact Details Added

Sample Input and Output 3
Enter No of Contacts:
4
Enter the Contact Details
Helana,9788919989,7334412367,289234,helana@gmail.com,Sydney
Elana,9788923957,7334512345,234234,elana@gmail.com,Melbourne
Elana,9788923957,7334512345,234234,elana@gmail.com,Melbourne
John,9788973257,7335672345,231204,john@gmail.com,Chandigarh
Contact Details Added
 
*/
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args){
        try
        {
            List<Contact> contacts = new List<Contact>();
            Console.WriteLine("Enter No of Contacts:");
            int noOfContacts = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Contact Details");
            for (int i = 0; i < noOfContacts; i++)
            {
                string det = Console.ReadLine();
                string[] details = det.Split(",");
                long mobile = long.Parse(details[1]);
                long altMobile = long.Parse(details[2]);
                Contact contact = new Contact(details[0],mobile,altMobile,details[4],details[5]);
                contacts.Add(contact);
            }
            
            new ContactBO().AddData(contacts);
        }
        catch (IOException e)
        {
            Console.WriteLine("Message :"+e.Message);            
        }
    }
}
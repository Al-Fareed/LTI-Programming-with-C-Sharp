/*
Displaying the ItemType Details

The International Film Festival of India (IFFI), founded in 1952, is one of the most significant film festivals in Asia. The festival is for a week and arrangements have to be made for food, chairs, tables, etc. The organizing committee plans to deposit the advance amount to the contractors on confirmation of booking. Help them to store these details and print them in detailed view.

Write a C# program to get item type name, cost per day and deposit amount from user and display these details in a detailed view using the following classes and methods.


[Note : Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider a class named ItemType.
It must have the following private member variables/attributes.

Data type	Attributes
string	_name
double	_costPerDay
double	_deposit

Include appropriate  getters and setters.

The ItemType class includes the following method. 

Method name	Description
public void Display()	In this method, fill in the code to display the details of the ItemType in the format as shown in the sample output.
Include the statement ‘Item type details’ inside this method.

Create another class Program and write a main method to test the above class.

In the Main() method, read the item type details from the user and create an ItemType object with the given details and call the Display( ) method.

Please use the below sample conventions to create getters and setters of the class ItemType

  
private string _name;
public string Name {
    get{   
        return this._name;  
    }  
    set{   
        this._name = value;   
    } 
}
 

The link to download the template code is given below
Code Template


Input and Output Format:
Refer sample input and output for formatting specifications.

Note:
costPerDay and deposit should be displayed up to 2 decimal places.


[All text in bold correspondstoinput and the rest corresponds to the output.]

Sample Input and Output 1:

Enter the item type name
Catering
Enter the cost per day
25000.00
Enter the deposit
10000.50
Item type details
Name:Catering
CostPerDay:25000.00
Deposit:10000.50
*/
using System;
class Program{
    static void Main(){
        ItemType i=new ItemType();
        Console.WriteLine("Enter the item type name");
        i.Name = Console.ReadLine();
        Console.WriteLine("Enter the cost per day");
        i.CostPerDay=double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the deposit");
        i.Deposit=double.Parse(Console.ReadLine());
 
        i.Display();
    }
}
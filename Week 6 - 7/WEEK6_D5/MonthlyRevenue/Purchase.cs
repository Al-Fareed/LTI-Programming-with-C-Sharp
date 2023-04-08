/*
Monthly Revenue
In John's department store, they planned to improve the sales therefore they decided to find the monthly revenue of the store, so that they could find some option and improve their sales. Hence, they approached you to create an application to find monthly revenue of the departmental store.

Write a c# program to find the monthly revenue of the departmental store in the ascending order of year.

[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Purchase with the following private attributes,

Data type	Attributes
int	_customerId
DateTime	_purchasedDate
int	_amount
The methods for getters, setters and constructors are given in the template code.

Consider the class Program. It includes the method Main.
In the Main method,

read the purchase details from the user, write a linq query to find the monthly revenue by grouping the year and month, display the details in ascending order of year. Include the statement “Monthly Revenue” before displaying the revenue.
 

The link to download the template code is given below
Code Template


Input and Output Format :

The date format should be “yyyy-MM-dd”. 
The output consists of monthly revenue details sorted by ascending order of purchased year.
Use the below format to display revenue details
Console.WriteLine("{0,-7}{1,-7}{2,-7}","Year","Month","Amount")
Refer sample input and output for formatting specifications. 

[All text in bold corresponds to input and rest corresponds to output.]


Sample Input And Output 1: 

Enter the number of purchase
6
Enter customer id
1
Enter purchased date
2015-01-01
Enter amount
1000
Enter customer id
2
Enter purchased date
2014-12-23
Enter amount
2000
Enter customer id
1
Enter purchased date
2015-01-07
Enter amount
1000
Enter customer id
1
Enter purchased date
2015-02-04
Enter amount
1500
Enter customer id
2
Enter purchased date
2015-02-06
Enter amount
1000
Enter customer id
3
Enter purchased date
2015-03-02
Enter amount
1000
Monthly Revenue
Year   Month  Amount 
2014   12     2000   
2015   1      2000   
2015   2      2500   
2015   3      1000
*/
using System;
class Purchase
{
    private int _customerId;
    private DateTime _purchasedDate;
    private int _amount;

    public Purchase(){}

    public Purchase(int _customerId, DateTime _purchasedDate, int _amount)
    {
        this._customerId = _customerId;
        this._purchasedDate = _purchasedDate;
        this._amount = _amount;
    }

    public int CustomerId { get => _customerId; set => _customerId = value; }
    public DateTime PurchasedDate { get => _purchasedDate; set => _purchasedDate = value; }
    public int Amount { get => _amount; set => _amount = value; }
}

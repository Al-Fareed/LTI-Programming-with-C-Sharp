/*
Display the Sales
In Steffan's shop many products are purchased in every year. He wants to know the purchases in particular season based on start and end date. So that they could verify the products purchased. Hence they approached you to create an application.

Write a C# program to find the sales done between start and end date (Both inclusive).

[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Purchase with the following private attributes

Data Type	Attributes
int	_customerId
DateTime	_purchasedDate
int	_amount
The methods for getters, setters and constructors are given in the template code.

 

Consider the class Program. It includes the method Main.
In the Main method,

read the purchase details from the user, write a linq query to find the purchases between given start and end date.
 

The link to download the template code is given below
Code Template


Input and Output Format :

The date format should be “yyyy-MM-dd”. 
Use the below format to display purchase details
Console.WriteLine("{0,-10}{1,-15}{2,-10}","Customer","PurchasedDate","Amount");
If there is no purchase found for given start and end date then display “No purchase found”.
Display the purchase details in insertion order.
Refer sample input and output for formatting specifications. 

[All text in bold corresponds to input and rest corresponds to output.]

Sample Input and Output 1: 

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
Start date
2014-12-01
End date
2015-01-01
Customer  PurchasedDate  Amount    
1         2015-01-01     1000      
2         2014-12-23     2000      

Sample Input and Output 2: 

Enter the number of purchase
3
Enter customer id
1
Enter purchased date
2016-08-05
Enter amount
1000
Enter customer id
2
Enter purchased date
2016-02-19
Enter amount
8000
Enter customer id
3
Enter purchased date
2016-01-15
Enter amount
7000
Start date
2017-01-15
End date
2017-04-01
No purchase found
*/
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of purchase");
        int n = int.Parse(Console.ReadLine());
        //Fill your code here
        List<Purchase> purchaseList = new List<Purchase>();
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter customer id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter purchased date");
            string dt = Console.ReadLine();
            DateTime date;
            if (!DateTime.TryParseExact(dt, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine("Invalid date format. Please enter the date in the format yyyy-MM-dd");
                return;
            }
            Console.WriteLine("Enter amount");
            int amount = int.Parse(Console.ReadLine());
            //Fill your code here
            purchaseList.Add(new Purchase(id, date, amount));
        }
        Console.WriteLine("Start date");
        string sDate = Console.ReadLine();
        DateTime startDate;
        if (!DateTime.TryParseExact(sDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate)){}
        Console.WriteLine("End date");
        string eDate = Console.ReadLine();
        DateTime endDate;
        if (!DateTime.TryParseExact(eDate, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate)){}
        //Fill your code here
        //Fill your code here
        var result = (from item in purchaseList
                      where item.PurchasedDate >= startDate && item.PurchasedDate <= endDate
                      select item
        ).ToArray();

        if (result.Length > 0)
        {
            Console.WriteLine("{0,-10}{1,-15}{2,-10}", "Customer", "PurchasedDate", "Amount");
            foreach (var item in result)
            {
                Console.WriteLine("{0,-10}{1,-15}{2,-10}", item.CustomerId, item.PurchasedDate.ToString("yyyy-MM-dd"), item.Amount);
            }
        }
        else
        {
            Console.WriteLine("No purchase found");
        }
    }
}

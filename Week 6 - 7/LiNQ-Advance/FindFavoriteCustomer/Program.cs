using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
class Program
{
    static void Main(string[] args)
    {
        //Fill your code here
        List<Customer> customers = new List<Customer>();
        List<Purchase> purchases = new List<Purchase>();

        Console.WriteLine("Enter Number of Customers :");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Name :");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter Last Name :");
            string lname = Console.ReadLine();
            //Fill your code here
            customers.Add(new Customer(id, fname, lname));
        }

        Console.WriteLine("Enter Number of Entry in database :");
        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Enter Customer Id :");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Purchased Date :");
            string dt = Console.ReadLine();
            DateTime date;
            DateTime.TryParseExact(dt, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);
            Console.WriteLine("Enter Amount :");
            long amount = long.Parse(Console.ReadLine());
            //Fill your code here
            purchases.Add(new Purchase(id, date, amount));
        }
        var result = from purchase in purchases
                     group purchase by purchase.CustomerId into customerPurchases
                     join customer in customers on customerPurchases.Key equals customer.Id
                     orderby customerPurchases.Count() descending
                     select customer;
        Console.WriteLine("Favorite Customer : {0} {1}", result.First().FirstName, result.First().LastName);
    }
}

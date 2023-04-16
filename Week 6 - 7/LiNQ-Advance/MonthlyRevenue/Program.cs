using System;
using System.Collections.Generic;
using System.Linq;

namespace DepartmentStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of purchase");
            int numPurchases = Convert.ToInt32(Console.ReadLine());

            List<Purchase> purchases = new List<Purchase>();

            for (int i = 1; i <= numPurchases; i++)
            {
                Console.WriteLine("Enter customer id");
                int customerId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter purchased date");
                DateTime purchasedDate = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

                Console.WriteLine("Enter amount");
                int amount = Convert.ToInt32(Console.ReadLine());

                purchases.Add(new Purchase(customerId, purchasedDate, amount));
            }

            var monthlyRevenue = from purchase in purchases
                                 group purchase by new { purchase.PurchasedDate.Year, purchase.PurchasedDate.Month } into monthlyGroup
                                 orderby monthlyGroup.Key.Year ascending
                                 select new { Year = monthlyGroup.Key.Year, Month = monthlyGroup.Key.Month, Amount = monthlyGroup.Sum(x => x.Amount) };

            Console.WriteLine("Monthly Revenue");
            Console.WriteLine("{0,-7}{1,-7}{2,-7}", "Year", "Month", "Amount");

            foreach (var revenue in monthlyRevenue)
            {
                Console.WriteLine("{0,-7}{1,-7}{2,-7}", revenue.Year, revenue.Month, revenue.Amount);
            }

            Console.ReadLine();
        }
    }
}

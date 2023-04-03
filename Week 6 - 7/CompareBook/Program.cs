using System;
public delegate int CompareBookDelegate(Book b1, Book b2);
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the book 1 details");
        Console.WriteLine("Enter the title");
        string title1 = Console.ReadLine();

        Console.WriteLine("Enter the author");
        string author1 = Console.ReadLine();
        
        Console.WriteLine("Enter the price");
        double price1 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the noOfPages");
        int noOfPages1 = int.Parse(Console.ReadLine());
        
        Book book1 = new Book(title1, author1, price1, noOfPages1);
        
        Console.WriteLine("Enter the book 2 details");
        Console.WriteLine("Enter the title");
        string title2 = Console.ReadLine();
        
        Console.WriteLine("Enter the author");
        string author2 = Console.ReadLine();
        
        Console.WriteLine("Enter the price");
        double price2 = double.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the noOfPages");
        int noOfPages2 = int.Parse(Console.ReadLine());
        Book book2 = new Book(title2, author2, price2, noOfPages2);
        CompareBookDelegate cbd = new CompareBookDelegate(book1.CompareBook);
        int diff = cbd(book2,book1);
        if(diff == 0){
            System.Console.WriteLine("Books are equal");
        }else{

            System.Console.WriteLine("Books are not equal");
        }
    }
}
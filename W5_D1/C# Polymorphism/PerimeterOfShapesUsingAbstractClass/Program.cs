using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Shapes\n1.Square\n2.Rectangle\n3.Circle\nEnter your choice");
        int choice = Convert.ToInt32(Console.ReadLine());
        //Fill your code here
        switch(choice){
            case 1: Console.WriteLine("Enter the side of the square");
                    double side=double.Parse(Console.ReadLine()); 
                    Square s=new Square(side);
                    Console.WriteLine("Perimeter of square is "+string.Format("{0:0.00}",s.Perimeter()));
                    break;
            case 2:Console.WriteLine("Enter the length of the rectangle");
                    double len = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the width of the rectangle");
                    double width = double.Parse(Console.ReadLine());
                    Rectangle r=new Rectangle(len,width);
                    Console.WriteLine("Perimeter of rectangle is "+string.Format("{0:0.00}",r.Perimeter()));
                    break;
            case 3: Console.WriteLine("Enter the radius of the circle");
                    double radius=double.Parse(Console.ReadLine());
                    Circle c=new Circle(radius);
                    Console.WriteLine($"Perimeter of circle is "+string.Format("{0:0.00}",c.Perimeter()));
                    break;
            default: Console.WriteLine("Invalid input");
                    break;
        }   
    }
}
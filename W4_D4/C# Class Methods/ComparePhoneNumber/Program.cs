using System;
class Program
{
    static void Main(string[] args)
    {
        User[] u = new User[2];
        for (int i = 0; i < 2; i++)
        {
            u[i] = new User();
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter UserName");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter PhoneNumber");
            long phoneNumber = long.Parse(Console.ReadLine());
            u[i] = new User(name, userName, password, phoneNumber);
        }
        if(u[0].ComparePhoneNumber(u[1])){
            Console.WriteLine("Same Users");
        }else{
            Console.WriteLine("Different Users");
        }
    }
}
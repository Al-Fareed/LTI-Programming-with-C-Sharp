using System;
using System.Collections.Generic;

namespace ListBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number of users");
            int numUsers = int.Parse(Console.ReadLine());

            List<User> userList = new List<User>();

            for (int i = 0; i < numUsers; i++)
            {
                string[] details = Console.ReadLine().Split(',');
                string name = details[0];
                string email = details[1];
                string contactNo = details[2];
                User user = new User(name, email, contactNo);
                userList.Add(user);
            }

            userList.Sort(new MyComparer());

            Console.WriteLine("Enter UserName to search");
            string searchName = Console.ReadLine();

            User userToFind = new User(searchName, "", "");

            int index = userList.BinarySearch(userToFind, new MyComparer());

            if (index >= 0)
            {
                Console.WriteLine("User Found ! User Details are");
                Console.WriteLine(userList[index].ToString());
            }
            else
            {
                Console.WriteLine("User Not Found");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace ListBinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            List<User> userList = new List<User>();

            Console.WriteLine("Enter total number of users");
            int noOfUsers = int.Parse(Console.ReadLine());

            for (int i = 0; i < noOfUsers; i++)
            {
                string[] details = Console.ReadLine().Split(",");
                string name = details[0];
                string email = details[1];
                string contactNo = details[2];
                User user = new User(name, email, contactNo);
                userList.Add(user);
            }
            userList.Sort(new MyComparer());

            Console.WriteLine("Enter UserName to search");
            string searchUser = Console.ReadLine();

            User userToSearch = new User(searchUser, "", "");

            int index = userList.BinarySearch(userToSearch, new MyComparer());

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

using System;
using System.Collections.Generic;

namespace ListBinarySearch
{
     public class MyComparer : IComparer<User>
    {
        public int Compare(User u1, User u2)
        {
            return u1.UserName.CompareTo(u2.UserName);
        }
    }
}

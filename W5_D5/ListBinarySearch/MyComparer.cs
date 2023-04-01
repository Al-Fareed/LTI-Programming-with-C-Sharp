using System;
using System.Collections.Generic;

namespace ListBinarySearch
{
    public class MyComparer : IComparer<User>
    {
        public int Compare(User x, User y)
        {
            return x.Username.CompareTo(y.Username);
        }
    }
}

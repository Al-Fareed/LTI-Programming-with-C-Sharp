using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1
{
    class EmailComparator : IComparer<User>
    {
        public int Compare(User u1, User u2)
        {
            // fill your code
            return u1.Email.CompareTo(u2.Email);
        }
    }
}

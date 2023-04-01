using System;

namespace ListBinarySearch
{
    public class User
    {
        private string _username;
        private string _email;
        private string _contactNo;

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string ContactNo
        {
            get { return _contactNo; }
            set { _contactNo = value; }
        }

        public User(string username, string email, string contactNo)
        {
            _username = username;
            _email = email;
            _contactNo = contactNo;
        }

        public override string ToString()
        {
            return string.Format("Username : {0}\nEmail : {1}\nContact No : {2}", _username, _email, _contactNo);
        }
    }
}

using System;

namespace ListBinarySearch
{
   public class User
    {
        private string _username, _email, _contactNo;
        public string UserName { 
            get=>_username;
            set=>_username=value;
        }
        public string Email { 
            get=>_email;
            set=>_email = value;
        }
        public string ContactNo { 
            get=>_contactNo;
            set=>_contactNo = value;
        }
        public User(string name, string mail, string contactNo)
        {
            _username = name;
            _email = mail;
            _contactNo = contactNo;
        }
        public override string ToString()
        {
            return string.Format("Username : {0}\nEmail : {1}\nContact No : {2}", _username, _email, _contactNo);
        }
    }
}

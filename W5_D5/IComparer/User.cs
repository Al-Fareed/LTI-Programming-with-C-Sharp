using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G1
{
    class User
    {
        private string _name;
        private string _email;
        private string _contactNo;
        public User(string _name, string _email, string _contactNo)
        {
            this._name = _name;
            this._email = _email;
            this._contactNo = _contactNo;
        }
        public string Name
        {
            get{return _name;}
            set{_name = value;}
        }
        public string Email
        {
            get{return _email;}
            set{_email = value;}
        }
        public string ContactNo
        {
            get{return _contactNo;}
            set{_contactNo = value;}
        }
     	// fill your code      
        
        public override string ToString(){
            return string.Format("{0,-15}{1,-15}{2,-20}",_name,_email,_contactNo);
        }
}
}

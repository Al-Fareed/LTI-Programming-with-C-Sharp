using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace ThreadingApplication3
{

    class User
    {

        private int _id;

        private string _userName;

        private string _contactNumber;

        private Event _event;

        private string _notificationMessage;


        public static List<User> userList = new List<User>();



        public static void Work(object list, object eventName)

        {

            //fill your code
        }



        public User(int id, string _userName, string _contactNumber, Event _event)

        {

            // fill your code     

        }



        // fill your code       



        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }
        public string ContactNumber
        {
            get
            {
                return _contactNumber;
            }
            set
            {
                _contactNumber = value;
            }
        }
        public Event Event
        {
            get
            {
                return _event;
            }
            set
            {
                _event = value;
            }
        }
        public string NotificationMessage
        {
            get
            {
                return _notificationMessage;
            }
            set
            {
                _notificationMessage = value;
            }
        }
    }
}

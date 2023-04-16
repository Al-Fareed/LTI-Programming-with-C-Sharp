public class Hall
    {
        private string _name;
        private long _mobileNumber;
        private double _costPerDay;
        private string _owner;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public long MobileNumber
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }

        public double CostPerDay
        {
            get { return _costPerDay; }
            set { _costPerDay = value; }
        }

        public string Owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public Hall()
        {
            // default constructor
        }

        public Hall(string name, long mobileNumber, double costPerDay, string owner)
        {
            _name = name;
            _mobileNumber = mobileNumber;
            _costPerDay = costPerDay;
            _owner = owner;
        }
    }

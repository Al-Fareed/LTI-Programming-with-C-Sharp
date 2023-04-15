using System;
public class HallBooking
    {
        private Hall _hallInstance;
        private Event _eventInstance;
        private DateTime _startDate;
        private DateTime _endDate;
        private double _price;

        public Hall HallInstance
        {
            get { return _hallInstance; }
            set { _hallInstance = value; }
        }

        public Event EventInstance
        {
            get { return _eventInstance; }
            set { _eventInstance = value; }
        }

        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public HallBooking()
        {
            // default constructor
        }

        public HallBooking(Event eventInstance, Hall hallInstance, DateTime startDate, DateTime endDate, double price)
        {
            _eventInstance = eventInstance;
            _hallInstance = hallInstance;
            _startDate = startDate;
            _endDate = endDate;
            _price = price;
        }
    }
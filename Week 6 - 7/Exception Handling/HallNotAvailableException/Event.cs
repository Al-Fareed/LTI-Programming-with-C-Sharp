using System;
using System.Collections.Generic;

   public class Event
    {
        private string _name;
        private string _detail;
        private string _type;
        private string _organizer;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Detail
        {
            get { return _detail; }
            set { _detail = value; }
        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public string Organizer
        {
            get { return _organizer; }
            set { _organizer = value; }
        }

        public Event()
        {
            // default constructor
        }

        public Event(string name, string detail, string type, string organizer)
        {
            _name = name;
            _detail = detail;
            _type = type;
            _organizer = organizer;
        }
    }

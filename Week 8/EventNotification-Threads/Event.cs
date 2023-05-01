using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;


namespace ThreadingApplication3

{

    class Event

    {
        public static List<Event> e = new List<Event>();

        private string _eventName;

        private string _eventType;

        public string EventName

        {

            get
            {
                return _eventName;
            }
            set
            {
                _eventName = value;
            }
        }
        public string EventType
        {
            get
            {
                return _eventType;
            }
            set
            {
                _eventType = value;
            }
        }



        public static Event GetEventObject(string _event)

        {

            // fill your code
            Event events = new Event();
            return events;
        }

        // return null;
    public Event(){}
    public Event(string _eventName, string _eventType)
    {
        this._eventName = _eventName;
        this._eventType = _eventType;
    }


        public static void preLoad()

        {

            e.Add(new Event("Rio Carnival", "Stage Show"));

            e.Add(new Event("Cannens Film", "Exhibition"));

            e.Add(new Event("Trick Eye", "StageShow"));

            e.Add(new Event("Tommorow land", "Exhibition"));


        }


        // fill your code



    }
}

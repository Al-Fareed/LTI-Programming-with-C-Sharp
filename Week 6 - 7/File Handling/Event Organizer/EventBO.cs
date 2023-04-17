using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class EventBO
{
    
    // public List<Event> AddEvent(string details, List<Event> eventList)
    // {
    //     //fill your code
    //     return
    // }
    public void EventDisplay(string organizer, List<Event> list)
    {
        //fill your code
        Console.WriteLine("Events Organized by " + organizer);
        bool found = false;
        foreach (Event item in list)
        {
            if (item.Organizer == organizer)
            {
                Console.WriteLine("Event Name: {0}", item.Name);
                Console.WriteLine("Event Type: {0}", item.Type);
                Console.WriteLine("Event Cost: {0}", item.Cost);
                found = true;
            }
        }
        if(!found)
            Console.WriteLine("No Event is found for this organizer...");
    }
}

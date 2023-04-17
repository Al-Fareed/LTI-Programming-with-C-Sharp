using System;
using System.Collections.Generic;
using System.IO;
public class EventBO
{
    public void WriteEvents(List<Event> list)
    {
        try
        {
            string path = "output.txt";
            StreamWriter writer = new StreamWriter(path);
            if(!File.Exists(path)) File.Create(path);
            foreach (Event item in list)
            {
                string writeFile = $"{item.Name},{item.Type},{item.Cost},{item.Organizer}";
                writer.WriteLine(writeFile);
            }
            writer.Close();
            Console.WriteLine("Event Details is written in the file");
        }
        catch (Exception)
        {

        }

    }
}
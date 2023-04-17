using System;
using System.Collections.Generic;
using System.IO;
public class ContactBO
{
    public void AddData(List<Contact> list)
    {
        try
        {
            string path = "output.csv";
            StreamWriter writer = new StreamWriter(path);
            foreach (Contact item in list)
            {
                string input = $"{item.Name},{item.Mobile},{item.AltMobile},{item.Email},{item.Address}";
                writer.WriteLine(input);
            }
            Console.WriteLine("Contact Details Added");
            writer.Close();
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
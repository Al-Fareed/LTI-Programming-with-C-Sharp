using System;
using System.IO;
using System.Collections.Generic;
public class AddressBO
{
    static List<Address> addresses = new List<Address>();

    public Address CreateAddress(string value)
    {
        //fill code here
        string[] details = value.Split(",");
        int pin = int.Parse(details[4]);
        // addresses.Add(new Address(details[0], details[1], details[2], details[3], pin));
        Address address = new Address(details[0], details[1], details[2], details[3], pin);
        return address;
    }

    public void Display(List<Address> list)
    {
        //fill code here
        foreach (Address item in list)
        {
            Console.WriteLine("{0,-15} {1,-25} {2,-15} {3,-15} {4,-15}",item.AddressLine1,item.AddressLine2,item.City,item.State,item.PinCode);
        }
    }
}
using System;
using System.IO;
public class Contact
{
    private string _name;
    private long _mobile;
    private long _altMobile;
    private string _address;
    private string _email;

    public string Name { get; set; }
    public long Mobile { get; set; }
    public long AltMobile { get; set; }
    public string Address { get; set; }
    public string Email { get; set; }

    public Contact() { }
    public Contact(string name, long mobile, long altMobile, string address, string email)
    {
        Name = name;
        Mobile = mobile;
        AltMobile = altMobile;
        Address = address;
        Email = email;
    }
}
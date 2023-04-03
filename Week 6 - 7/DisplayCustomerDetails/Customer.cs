using System;
class Customer
{
    public string _firstName;
    public string _lastName;

    public Customer(string firstName, string lastName)
    {
        _firstName = firstName;
        _lastName = lastName;
    }
    public void DisplayFirstName()
    {
        Console.WriteLine("First Name: "+_firstName);
    }
    public void DisplayLastName()
    {
        Console.WriteLine("Last Name: "+_lastName);

    }
}
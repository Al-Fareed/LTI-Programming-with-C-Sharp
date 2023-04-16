public class Customer
{
    private int _id;
    private string _firstName;
    private string _lastName;

    public int Id { get; set; }
    public int FirstName { get; set; }
    public int LastName { get; set; }

    public Customer(int id, string firstName, string lastName)
    {
        _id = id;
        _firstName = firstName;
        _lastName = lastName;
    }
    
}
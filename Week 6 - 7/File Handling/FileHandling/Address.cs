public class Address
{
    private string _addressLine1;
    private string _addressLine2;
    private string _city;
    private string _state;
    private int _pincode;

    public string AddressLine1 { get { return _addressLine1; } set { _addressLine1 = value; } }
    public string AddressLine2 { get { return _addressLine2; } set { _addressLine2 = value; } }
    public string City { get { return _city; } set { _city = value; } }
    public string State { get { return _state; } set { _state = value; } }
    public int Pincode { get { return _pincode; } set { _pincode = value; } }

    public Address()
    {
        _addressLine1 = "";
        _addressLine2 = "";
        _city = "";
        _state = "";
        _pincode = 0;
    }

    public Address(string addressLine1, string addressLine2, string city, string state, int pincode)
    {
        _addressLine1 = addressLine1;
        _addressLine2 = addressLine2;
        _city = city;
        _state = state;
        _pincode = pincode;
    }
}

class User
{
    private string	_name,	_username,	_password;
    private long _phoneNumber;  
    public User(){
        _name = "";
        _username = "";
        _password = "";
        _phoneNumber = 0;
    }
    public User(string _name,string _username,string _password,long _phoneNumber){
        this._name = _name;
        this._username = _username;
        this._password = _password;
        this._phoneNumber = _phoneNumber;
    }
    public string Name{
        get=>_name;
        set=>_name = value;
    }
    public string Username{
        get=>_username;
        set=>_username=value;
    }
    public string Password{
        get=>_password;
        set=>_password = value;
    }
    public long PhoneNumber{
        get=>_phoneNumber;
        set=>_phoneNumber = value;
    }
    public bool ComparePhoneNumber(User user){
        return _phoneNumber==user._phoneNumber;
    }
}
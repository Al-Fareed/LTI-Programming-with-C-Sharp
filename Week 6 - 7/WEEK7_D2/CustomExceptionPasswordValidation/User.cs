public class User
{
    private string _firstName;
    private string _lastName;
    private string _email;
    private string _password;

public User(){}
    public User(string _firstName, string _lastName, string _email, string _password)
    {
        this._firstName = _firstName;
        this._lastName = _lastName;
        this._email = _email;
        this._password = _password;
    }

    public string FistName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
    public string Password{get;set;}

    public void Display(){
        Console.WriteLine("First Name :{0}\nLast Name :{1}\nE-Mail :{2}\nPassword :{3}",FistName,LastName,Email);
    }
}
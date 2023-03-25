
class Customer : Program
{
     private int _id;
    private string _name,_email,_address,_purpose,_otherDetails;
    public int Id{
        set{this._id=value;}
        get{return _id;}
    }

    public string Name{
        set{this._name=value;}
        get{return _name;}
    }
    public string Email{
        set{this._email=value;}
        get{return _email;}
    }
    public string Address{
        set{this._address=value;}
        get{return _address;}
    }
    public string Purpose{
        set{this._purpose=value;}
        get{return _purpose;}
    }
    public string OtherDetails{
        set{this._otherDetails=value;}
        get{return _otherDetails;}
    }
    public void Display(){
        System.Console.WriteLine("Customer details are :\nID :{0}\nName:{1}Email :{2}\nAddress :{3}\nPurpose :{4}\nOther details :{5}\n",_id,_name,_email,_address,_purpose,_otherDetails);
    }
}
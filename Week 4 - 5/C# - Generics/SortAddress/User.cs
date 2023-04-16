using System;
using System.Collections.Generic;
class User : IComparable
{
    private string _name;
    private string _add1;
    private string _add2;
    private long _pincode;

    public User() { }
    public User(string _name, string _add1, string _add2, long _pincode)
    {
        this._name = _name;
        this._add1 = _add1;
        this._add2 = _add2;
        this._pincode = _pincode;
    }
    public int CompareTo(Object obj)
    {
        User user = obj as User;
        if (this._pincode.Equals(user._pincode))
            return this._add1.CompareTo(user._add1);
        else
            return this._pincode.CompareTo(user._pincode);
    }
    public override string ToString()
    {
        return string.Format("Name : {0} Address : {1},{2},{3}", _name, _add1, _add2, _pincode); ;
    }

}
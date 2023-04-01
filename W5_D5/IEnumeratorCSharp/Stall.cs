using System;
using System.Collections.Generic;
class Stall
{
    private string _name;
    private string _owner;
    private string _detail;

    public string Name{
        get=>_name;
        set=>_name = value;
    }
    public string Owner{
        get=>_owner;
        set=>_owner = value;
    }
    public string Detail{
        get=>_detail;
        set=>_detail = value;
    }
    public Stall(string _name, string _owner, string _detail)
    {
        this._name = _name;
        this._owner = _owner;
        this._detail = _detail;
    }
    public override string ToString()
    {
        return string.Format("Name : {0}\nOwner : {1}\nDetails : {2}",_name,_owner,_detail);
    }
}
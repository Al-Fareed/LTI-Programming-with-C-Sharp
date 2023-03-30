using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Event
{
    private string _name;
    private string _type;

    //fill code here
    public Event (string _name, string _type){
        this._name = _name;
        this._type = _type;
    }
    public string Name {
        get=>_name;
    }
    public string Type {
        get => _type;
    }

    public virtual double ProjectedRevenue()
    {
        return 0.0;
    }


}
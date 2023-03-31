using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Hall : IComparable
{
    private string _name;
    private long _mobileNumber;
    private string _ownerName;
    private double _costPerDay;
    public Hall(string _name,long _mobileNumber,string _ownerName,double _costPerDay)
    {
        this._name = _name;
        this._mobileNumber = _mobileNumber;
        this._ownerName = _ownerName;
        this._costPerDay = _costPerDay;
    }
    public int CompareTo(Object obj)
    {
        Hall hall = obj as Hall;
        //Fill your code here
        return this._costPerDay.CompareTo(hall._costPerDay);
    }
    public override string ToString()
    {
        //Fill your code here
        return string.Format("{0,-20} {1,-15} {2,-15} {3,-10}",_name,_mobileNumber,_ownerName,_costPerDay);
    }
    
}

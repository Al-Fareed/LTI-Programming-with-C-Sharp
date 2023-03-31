using System;
using System.Collections.Generic;
public class Hall
{
    public string _name;
    public string _contactNumber;
    public double _costPerDay;
    public string _ownerName;
    public Hall(){}
    public Hall(string name,string contactNumber,double costPerDay,string ownerName)
    {
        _name=name;
        _contactNumber= contactNumber;
        _costPerDay=costPerDay;
        _ownerName=ownerName;
    }
    public string Name{get;set;}
    public string ContactNumber{get;set;}
    public double CostPerDay{get;set;}
    public string OwnerName{get;set;}

}
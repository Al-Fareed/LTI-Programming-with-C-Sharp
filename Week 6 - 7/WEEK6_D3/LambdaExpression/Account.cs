using System;
using System.Collections.Generic;
using System.Diagnostics;

class Account
{
    private string aNumber;
    private double premium;
    private int discountPercent;

    public string AccNo{
        get=>aNumber;
        set=>aNumber = value;
    }
    public double Premium{
        get => premium;
        set => premium = value;
    }
    public int Discount{
        get=>discountPercent;
        set => discountPercent = value;
    }

    public Account(string aNumber,double premium,int discount)
    {
        this.aNumber = aNumber;
        this.premium = premium;
        this.discountPercent = discount;
    }

}
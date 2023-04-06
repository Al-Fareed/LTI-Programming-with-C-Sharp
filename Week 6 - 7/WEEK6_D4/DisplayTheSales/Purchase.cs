using System;
using System.Collections.Generic;
using System.Text;

class Purchase
{
    private int _customerId;
    private DateTime _purchasedDate;
    private int _amount;

    public Purchase()
    {
    }

    public Purchase(int _customerId, DateTime _purchasedDate, int _amount)
    {
        this._customerId = _customerId;
        this._purchasedDate = _purchasedDate;
        this._amount = _amount;
    }

    public int CustomerId { get => _customerId; set => _customerId = value; }
    public DateTime PurchasedDate { get => _purchasedDate; set => _purchasedDate = value; }
    public int Amount { get => _amount; set => _amount = value; }

}

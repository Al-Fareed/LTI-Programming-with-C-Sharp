public class Purchase
{
    private int _customerId;
    private DateTime _purchasedDate;
    private long _amount;

    public Purchase(int _customerId, DateTime _purchasedDate,long _amount)
    {
        this._customerId = _customerId;
        this._purchasedDate = _purchasedDate;
        this._amount = _amount;
    }
    public int CustomerId{get;set;}
    public DateTime PurchasedDate{get;set;}
    public long Amount{get;set;}
}
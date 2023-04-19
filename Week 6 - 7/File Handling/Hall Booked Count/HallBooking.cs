using System;

class HallBooking
{
    private Event _eventInstance;
    private Hall _hallInstance;
    private DateTime _startDate;
    private DateTime _endDate;
    private double _price;


    public Hall HallInstance
    {
        get { return this._hallInstance; }
        set { this._hallInstance = value; }
    }

    public Event EventInstance
    {
        get { return this._eventInstance; }
        set { this._eventInstance = value; }
    }

    public DateTime StartDate
    {
        get { return this._startDate; }
        set { this._startDate = value; }
    }

    public DateTime EndDate
    {
        get { return this._endDate; }
        set { this._endDate = value; }
    }

    public double Price
    {
        get { return this._price; }
        set { this._price = value; }
    }


    public HallBooking() { }

    public HallBooking(Event _eventInstance, Hall _hallInstance, DateTime _startDate, DateTime _endDate, double _price)
    {
        this._eventInstance = _eventInstance;
        this._hallInstance = _hallInstance;
        this._startDate = _startDate;
        this._endDate = _endDate;
        this._price = _price;
    }

}
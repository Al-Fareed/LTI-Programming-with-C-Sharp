using System;
public class SeatNotAvailableException : Exception
{
    public SeatNotAvailableException(string message) : base(message){}
}
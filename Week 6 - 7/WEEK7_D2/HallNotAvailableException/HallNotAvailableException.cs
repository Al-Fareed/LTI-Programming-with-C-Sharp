using System;
public class HallNotAvailableException : Exception
{
    public HallNotAvailableException(string message) : base(message){}
}
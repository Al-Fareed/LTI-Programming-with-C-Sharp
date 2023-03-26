using System;
class Stall
{
    private string stallType;
    private int squareFeet, numberOfTV;
    bool projectorAvailability;

    public string StallType
    {
        get => stallType;
        set => this.stallType = value;
    }
    public int SquareFeet
    {
        get => squareFeet;
        set => this.squareFeet = value;
    }
    public int NumberOfTV
    {
        get => numberOfTV;
        set => this.numberOfTV = value;
    }
    public bool ProjectorAvailability
    {
        get => projectorAvailability;
        set => this.projectorAvailability = value;
    }

    public void ComputeCost(string stallType, int squareFeet)
    {
        Console.WriteLine("{0} costs Rs.{1}", stallType, (squareFeet * 100));
    }
    public void ComputeCost(string stallType, int squareFeet, int numberOfTV)
    {
        int total=((squareFeet * 150) + (numberOfTV * 100));
        Console.WriteLine("{0} costs Rs.{1}", stallType, total);
    }
    public void ComputeCost(string stallType, int squareFeet, bool projectorAvailability)
    {
        int total;
        if (projectorAvailability)
        {
            total = (squareFeet * 200) + (1000);
        }
        else
        {
            total = (squareFeet * 200);

        }

        Console.WriteLine("{0} costs Rs.{1}", stallType, total);


    }

}
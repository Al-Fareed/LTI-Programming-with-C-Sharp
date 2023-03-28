using System;

class Square : Shape //Fill your code here
{
    private double _side;

    public double Side
    {
        get { return this._side; }
        set { this._side = value; }
    }

    public Square(){}
    
    public Square(double _side){
        this._side = _side;
    }
    public override double Perimeter(){
        return 4*_side;
    }
    
    // Fill your code here. Define the abstract method Perimeter() 
}
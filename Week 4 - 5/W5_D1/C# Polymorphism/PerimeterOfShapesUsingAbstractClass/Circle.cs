using System;

class Circle : Shape //Fill your code here
{
    private double _radius;

    public double Radius
    {
        get { return this._radius; }
        set { this._radius = value; }
    }
    public Circle(){}
    
    public Circle(double _radius){
        this._radius = _radius;
    }

    // Fill your code here. Define the abstract method Perimeter() 
    public override double Perimeter(){
        return (2*3.14*_radius);
    }
}
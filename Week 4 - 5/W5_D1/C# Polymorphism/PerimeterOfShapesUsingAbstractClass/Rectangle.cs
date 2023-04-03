using System;

class Rectangle : Shape//Fill your code here
{
    private double _length;
    private double _width;

    public double Length
    {
        get { return this._length; }
        set { this._length = value; }
    }

    public double Width
    {
        get { return this._width; }
        set { this._width = value; }
    }
    public Rectangle(){}

    public Rectangle(double _length,double _width){
        this._length = _length;
        this._width = _width;
    }

    // Fill your code here. Define the abstract method Perimeter() 
    public override double Perimeter(){
        return (2*(_length+_width));
    }
} 
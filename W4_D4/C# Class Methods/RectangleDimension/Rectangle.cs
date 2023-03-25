using System;
public class Rectangle
{
    private int _length;
    private int _width;

    public Rectangle()
    {
        _length = 0;
        _width = 0;
    }
    public Rectangle(int _length, int _width)
    {
        this._length = _length;
        this._width = _width;
    }
    public int Length
    {
        get => _length;
        set => _length = value;
    }
    public int Width
    {
        get => _width;
        set => _width = value;
    }

    public int Area()
    {
        return Length * Width;
    }

    public void Display()
    {
        Console.WriteLine("Rectangle Dimension\nLength:{0}\nWidth:{1}\nArea of the Rectangle:"+Area(), _length, _width);
    }

    public Rectangle DimensionChange(int d)
    {
        _length=_length*d;
        _width=_width*d;
        Rectangle newRect = new Rectangle(_length, _width);
        return newRect;
    }
}

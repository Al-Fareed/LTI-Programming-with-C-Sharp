using System;

public class Course
{
    private string _id;
    private string _name;
    private string _category;
    private int _price;

    public Course(string id, string name, string category, int price)
    {
        _id = id;
        _name = name;
        _category = category;
        _price = price;
    }

    public string Id
    {
        get { return _id; }
        set { _id = value; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Category
    {
        get { return _category; }
        set { _category = value; }
    }

    public int Price
    {
        get { return _price; }
        set { _price = value; }
    }
}

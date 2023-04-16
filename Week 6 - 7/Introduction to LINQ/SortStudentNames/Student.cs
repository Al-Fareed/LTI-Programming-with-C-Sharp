using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    private int _id;
    private string _name;
    private int _age;

    public Student()
    {
    }

    public Student(int _id, string _name, int _age)
    {
        this._id = _id;
        this._name = _name;
        this._age = _age;
    }

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }
    public int Age { get => _age; set => _age = value; }
}

public class Student
{
    private int _id;
    private string _name;
    private int _companyId;

    public int Id{
        get => _id;
        set =>_id = value;
    }
    public string Name{
        get => _name;
        set => _name = value;
    }
    public int CompanyId{
        get => _companyId;
        set => _companyId = value;
    }
    public Student(int id,string name, int companyId)
    {
        _id = id;
        _name = name;
        _companyId = companyId;
    }
}
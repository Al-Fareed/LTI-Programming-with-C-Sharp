public class Student
{
    private string _name;
    private int _problemCount;
    public Student(string name, int count)
    {
        _name = name;
        _problemCount = count;
    }
    public string Name
    {
        get => _name;
    }
    public int ProblemCount
    {
        get => _problemCount;
    }
}
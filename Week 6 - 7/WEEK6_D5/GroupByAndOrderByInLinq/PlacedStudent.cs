using System;
public class PlacedStudent
{
	private string _companyName;
	private string _studentName;

	public PlacedStudent(){}

    public PlacedStudent(string _companyName, string _studentName)
    {
        this._companyName = _companyName;
        this._studentName = _studentName;
    }

    public string CompanyName
    {
        get { return _companyName; }
        set { this._companyName = value; }
    }

    public string StudentName
    {
        get { return _studentName; }
        set { this._studentName = value; }
    }
}

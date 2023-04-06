using System;
     
public class Course
{
	private string _id;
	private string _name;
	private string _category;
	private int _price;
	
	public Course(){}
	
	public Course(string _id,string  _name,string  _category,int  _price)
	{
		this._id=_id;
		this._name=_name;
		this._category=_category;
		this._price=_price;
	}
	public string Name
	{
		get{return this._name;}
		set{this._name=value;}
	}
	public string Category
	{
		get{return this._category;}
		set{this._category=value;}
	}
	public string Id
	{
		get{return this._id;}
		set{this._id=value;}
	}
		public int Price
	{
		get{return this._price;}
		set{this._price=value;}
	}
}

using System;

partial class Product
{
	private string _name;
	public string Name
	{
		get { return _name; }
		set { _name = value; }
	}
	private int _level;
	public int Level 
	{
		get {return _level; }
		set { _level = value; }
	}
}

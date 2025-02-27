using System;

class Enrollment
{
	string _courseName;
	public string Name
	{
		get { return _courseName; }
		set { _courseName = value; }
	}
	string _instructor;
	public string Instructor
	{
		get {return _instructor; }
		set { _instructor = value; }
	}
	int _count;
	public int Count
	{
		get { return _count; }
		set { _count = value; }
	}
	public Enrollment(string Name, string Instructor, int Count)
	{
		this.Name = Name;
		this.Instructor = Instructor;
		this.Count = Count;
	}
	public void ShowCourseDetails()
	{
		Console.WriteLine("<------------>");
		Console.WriteLine($"Name: {Name}\nInstructor: {Instructor}\nStudent count: {Count}");
	}
	public static Enrollment AddElement()
	{
		Console.Write("Enter course name: ");
		string? name = Console.ReadLine();
		Console.Write("Enter instructor name: ");
		string? instructor = Console.ReadLine();
		Console.Write("Enter maximum count for student: ");
		int count = Convert.ToInt32(Console.ReadLine());
		return new Enrollment(name, instructor, count);
	}
}
class Program
{
	static void Main()
	{
		Enrollment[] arr = new Enrollment[3];
		Console.WriteLine("Hello claent...");
		for (int i = 0; i < 3; ++i) 
		{
			arr[i] = Enrollment.AddElement();
		}
		for (int i = 0; i < 3; ++i)
		{
			arr[i].ShowCourseDetails();
		}
	}
}

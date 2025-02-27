using System;

class Student 
{
	private string _name;
	public string Name 
	{
		get { return _name; }
		set { _name = value; }
	}
	private int _studentId;
	public int StudentId 
	{
		get { return _studentId; }
		set { _studentId = value; }
	}
	private int _grade;
	public int Grade 
	{
		get { return _grade; }
		set { _grade = value; }
	}
	public Student (string Name, int Id, int Grade)
	{
		this.Name = Name;
		this.StudentId = Id;
		this.Grade = Grade;
	}
	public void ShowStudentInfo() 
	{
		Console.WriteLine($"Name: {Name}\nId: {StudentId}\nGrade: {Grade}");
	}
	public static Student AddStudent()
	{
		Random rand = new Random();
		Console.Write("Enter your name: ");
		string? name = Console.ReadLine();
		Console.Write("Enter your grade: ");
		int grade = Convert.ToInt32(Console.ReadLine());
		return new Student(name, rand.Next(100000, 999999), grade);
	}

}
class Program
{
	static void Main()
	{
		Student[] students = new Student[10];
		int count = 0;
		Console.WriteLine("Hello claent..\nMy program have command --- add - print - exit ---");
		while (true) 
		{
			Console.Write("Enter command: ");
			string? com = Console.ReadLine();
			if (com == "add") 
			{
				students[count++] = Student.AddStudent();
			}
			else if (com == "print") 
			{
				for (int i = 0; i < count; ++i) 
				{
					students[i].ShowStudentInfo();
				}
			}
			else if (com == "exit") 
			{
				break;
			}
			else 
			{
				Console.WriteLine("invalid command!");
			}
		}
	}
}

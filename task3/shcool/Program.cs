using System;
public class Student 
{
	private string _name;
	public string StudentName 
	{
		get { return _name; }
		set {_name = value; }
	}

	private int _age;
	public int StudentAge 
	{
		get { return _age; }
		set { _age = value; }
	}
	private int _grade;
	public int StudentGrade 
	{
		get { return _grade; }
		set { _grade = value; }
	}
	public Student(string name, int age,  int grade) 
	{
		_name = name;
		_age = age;
		_grade = grade;
	}
}
public class Teacher {
	private string _name;
	public string TeacherName 
	{
		get { return _name; }
		set { _name = value; }
	}

	private string _subject;
	public string TeacherSubject 
	{
		get { return _subject; }
		set { _subject = value; }
	}
	private int _experience;
	public int YoursOfExperience 
	{
		get { return _experience; }
		set { _experience = value; }
	}
	public Teacher(string name, string subject, int experience) 
	{
		TeacherName = name;
		TeacherSubject = subject;
		YoursOfExperience = experience;
	}
}
public class School 
{
	public List<Student> students { get; set; }
	public List<Teacher> teachers { get; set; }
	public School()
	{
		students = new List<Student>();
		teachers = new List<Teacher>();
	}

	public void AddStudent(Student student) 
	{
		students.Add(student);
	}
	public void AddTeacher(Teacher teacher) 
	{
		teachers.Add(teacher);
	}
	public void DesplayStudent(Student stud) 
	{
		Console.WriteLine("name is -> {0}\nage is -> {1}\ngrade is -> {2}", stud.StudentName, stud.StudentAge, stud.StudentGrade);
	}
	public void DesplayTeacher(Teacher teach) 
	{
		Console.WriteLine($"name is -> {teach.TeacherName}\nsubject is -> {teach.TeacherSubject}\nexperience is {teach.YoursOfExperience}");
	}
}
class Program 
{
	static void Main() {
		School school = new School();
		Console.WriteLine("Hello client..");
		int StudentCount;
		while (true) 
		{
			Console.Write("Import the number of students you want: ");
			StudentCount = Convert.ToInt32(Console.ReadLine());
			if (StudentCount > 0) 
			{
				break;
			}
		}
		while (StudentCount != 0) 
		{
			Console.Write("Enter the student's name: ");
			string? name = Console.ReadLine();
			Console.Write("Enter the student's age: ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter student grade: ");
			int grade = Convert.ToInt32(Console.ReadLine());
			Student stud = new Student(name, age, grade);
			school.AddStudent(stud);
			--StudentCount;
		}
		int TeacherCount;
		while (true) 
		{
			Console.Write("Number of incoming professors: ");
			TeacherCount = Convert.ToInt32(Console.ReadLine());
			if (TeacherCount > 0) 
			{
				break;
			}
		}
		while (TeacherCount != 0) 
		{
			Console.Write("Enter the teacher's name: ");
			string? name = Console.ReadLine();
			Console.Write("Enter the subject taught by the instructor: ");
			string? subject = Console.ReadLine();
			Console.Write("Enter how many years the lecturer has been teaching: ");
			int experience = Convert.ToInt32(Console.ReadLine());
			Teacher teach = new Teacher(name, subject, experience);
			school.AddTeacher(teach);
			--TeacherCount;
		}
		
		foreach (var s in school.students) 
		{
			if (s.StudentGrade > 17) 
			{
				Console.WriteLine("-----Student-----");
				school.DesplayStudent(s);
			}
		}
		foreach (var t in school.teachers) {
			if (t.YoursOfExperience < 2) 
			{
				Console.WriteLine("-----Teacher-----");
				school.DesplayTeacher(t);
			}
		}
	}
}

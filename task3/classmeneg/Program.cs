using System;

public class Student {
	string? name = null;
	int age = 0;
	int grade = 0;
	private Student(string mname, int mage, int mgrade) {
		name = mname;
		age = mage;
		grade = mgrade;
	}
	public void DicplayDetails() {
		Console.WriteLine($"\nname: {name}\nage: {age}\nGrad: {grade}");
	}
	public static Student foo() {
			Console.WriteLine($"Contact for student");
			Console.Write("\tEnter name: ");
			string name = Console.ReadLine();
			Console.Write("\tEnter age: ");
			int age = Convert.ToInt32(Console.ReadLine());
			Console.Write("\tEnter grad: ");
			int grad = Convert.ToInt32(Console.ReadLine());
			return (new Student(name, age, grad));
	}

}
class Program {
	static void Main() {
		Student[] stud = new Student[5];
		for (int i = 0; i < 5; ++i) {
			stud[i] = Student.foo();
		}
		for (int i = 0; i < 5; ++i) {
			stud[i].DicplayDetails();
		}
	}
}

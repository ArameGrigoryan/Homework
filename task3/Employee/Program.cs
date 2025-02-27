using System;

public class Employee {
	public string? name = null;
	public string? position = null;
	int hour = 0;

	public Employee(string name, string position, int hour) {
		this.name = name;
		this.position = position;
		this.hour = hour;
	}

	public int Salary() {
		if (position == "letenant") {
			if (this.hour > 8) {
				int sum = 5000 * 8;
				this.hour -= 8;
				sum += this.hour * (5000 + (5000 / 2));
				return sum;
			}
			return 5000 * this.hour;
		}
		else if (position == "mayor") {
			if (this.hour > 8) {
				int sum = 7000 * 8;
				this.hour -= 8;
				sum += this.hour * (7000 + (7000 / 2));
				return sum;
			}

			return 7000 * this.hour;
		}
		else if (position == "general") {
			if (this.hour > 8) {
				int sum = 10000 * 8;
				this.hour -= 8;
				sum += this.hour * (10000 + (10000 / 2));
				return sum;
			}

			return 10000 * this.hour;
		}
		else {
			return 0;
		}
	}
}
class Program {
	static void Main() {
		Employee[] member = new Employee[3];
		for (int i = 0; i < 3; ++i) {
			Console.Write("enter your name: ");
			string? name = Console.ReadLine();
			Console.Write("Enter your position(letenant, mayor, general): ");
			string? position = Console.ReadLine();
			Console.Write("Enter hours of work: ");
			int hour = Convert.ToInt32(Console.ReadLine());
			member[i] = new Employee(name, position, hour);
		}
		for (int i = 0; i < 3; ++i) {
			Console.WriteLine($"{member[i].position} {member[i].name} your salary is -> " + member[i].Salary());
		}
	}
}

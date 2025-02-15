using System;

class Program {
	static void Main() {
		Console.Write("Enter number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		for (int i = 2; i < num; ++i) {
			if (num % i == 0) {
				Console.WriteLine("number is nut prime");
				return;
			}
		}
		Console.WriteLine("number is prime");
	}
}


using System;

class Program {
	static void Main() {
		Console.Write("Enter number: ");
		int num = Convert.ToInt32(Console.ReadLine());

		for (int i = 1; i <= num; ++i) {
			for (int j = 1; j <= i; ++j) {
				Console.Write("{0}", i);
			}
			Console.WriteLine("");
		}
	}
}


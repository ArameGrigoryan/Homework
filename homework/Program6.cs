using System;

class Program {
	static void Main() {
		Console.Write("Enter number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		int count = 0;
		while (num != 1) {
			if (num % 2 != 0) {
				num = num * 3 + 1;
			}
			else {
				num = num / 2;
			}
			++count;
		}
		Console.WriteLine("result is: {0}", count);
	}
}


using System;

class Program {
	static void Main() {
		Console.Write("enter number: ");
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("result is: {0}", foo(num));
	}
	public static int foo(int num) {
		int num2 = 0;
		while (num != 0) {
			num2 *= 10;
			num2 += num % 10;
			num /= 10;
		}
		return num2;
	}
}


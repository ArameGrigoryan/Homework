using System;

class Program {
	static void Main() {
		Console.Write("Enter number for fibonachi:");
		int index = Convert.ToInt32(Console.ReadLine());
		int sum1 = 0;
		int sum2 = 1;
		int res = 0;
		for (int i = 0; i < index - 1; ++i) {
			res = sum1 + sum2;
			sum1 = sum2;
			sum2 = res;

		}
		Console.Write("result is: {0}", res);
	}
}


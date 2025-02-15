using System;
class Program {
	static void Main() {
		Console.Write("Enter sentens:  ");
		string? num = Console.ReadLine();
		string[] nums = num.Split(" ");
		int max = -1;
		foreach(string sim in nums) {		
			if (max < sim.Length) {
				max = sim.Length;
			}
		}
		Console.WriteLine("result is: {0}", max);
	}
}


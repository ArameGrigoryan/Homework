using System;

class Sum
{
	private void foo(ref int res, int[] arr)
	{
		foreach (int tmp in arr)
		{
			res += tmp;
		}
	}
	private int[] Enter()
	{
		Console.WriteLine("Enter count for array: ");
		int count = Convert.ToInt32(Console.ReadLine());
		int[] arr = new int[count];
		for (int i = 0; i < count; ++i)
		{
			Console.Write("Enter element for array: ");
			arr[i] = Convert.ToInt32(Console.ReadLine());
		}
		return arr;
	}
	public void Run()
	{
		int[] arr = Enter();
		int res = 0;
		foo(ref res, arr);
		Console.WriteLine("Result is: {0}", res);
	}
}
class Program
{
	static void Main()
	{
		Sum tmp = new Sum();
		tmp.Run();
	}
}

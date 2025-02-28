using System;

class MaxNumber
{
	public void Max(ref int res, params int[] arr)
	{
		int max = 0;
		foreach (int elem in arr)
		{
			if (max < elem)
			{
				max = elem;
			}
		}
		res = max;
	}
}
class Program
{
	static void Main()
	{
		MaxNumber obj = new MaxNumber();
		int res = 0;
		obj.Max(ref res, 1, 2, 9, 3, 4, 7, 5, 0, 7);
		Console.WriteLine("Result is: {0}", res);
	}
}

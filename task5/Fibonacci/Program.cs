using System;

class Fibonacci
{
	public void Run()
	{
		int index = 0;
		while (true)
		{
			Console.Write("Enter index for number: ");
			index = Convert.ToInt32(Console.ReadLine());
			if (index >= 0)
			{
				break;
			}
			Console.WriteLine("invalid index!");
		}
		Console.WriteLine("Element for this index: {0}", Fib(index));
	}
	private int Fib(int index)
	{
		if (index == 0) 
		{ 
			return 0;
		}
		else if (index == 1)
		{
			return 1;
		}
		return Fib(index - 1) + Fib(index - 2);
	}
}
class Program
{
	static void Main()
	{
		Fibonacci fib = new Fibonacci();
		fib.Run();
	}
}

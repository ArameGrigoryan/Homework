using System;

class Calculator
{
	private double Add(double a, double b)
	{
		return a + b;
	}
	private double Sub(double a, double b)
	{
		return a - b;
	}
	private double Mul(double a, double b)
	{
		return a * b;
	}
	private double Div(double a, double b)
	{
		if (a == 0.0 || b == 0.0)
		{
			Console.WriteLine("Invalid arguments!");
			return 0.0;
		}
		return a / b;
	}
	public void Run()
	{
		Console.Write("Enter number 1: ");
		string? a = Console.ReadLine();
		Console.Write("Enter number 2: ");
		string? b = Console.ReadLine();
		if (a.Equals("x", StringComparison.OrdinalIgnoreCase) || b.Equals("x", StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		Console.Write("Enter arithmetic operation(+ - * /): ");
		string? operation = Console.ReadLine();
		switch (operation)
		{
			case "+":
				Console.WriteLine("Result is: {0}", Add(double.Parse(a), double.Parse(b)));
				break;
			case "-":
				Console.WriteLine("Result is: {0}", Sub(double.Parse(a), double.Parse(b)));
				break;
			case "*":
				Console.WriteLine("Result is: {0}", Mul(double.Parse(a), double.Parse(b)));
				break;
			case "/":
				Console.WriteLine("Result is: {0}", Div(double.Parse(a), double.Parse(b)));
				break;
			default:
				Console.WriteLine("invalid operation!");
				break;
		}
		Run();
	}
}
class Program
{
	static void Main()
	{
		Console.WriteLine("Calculate: Hello claent...");
		Calculator tmp = new Calculator();
		tmp.Run();
	}
}

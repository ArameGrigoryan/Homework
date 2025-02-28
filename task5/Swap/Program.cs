using System;

class Swap
{
	public void foo(ref int a, ref int b)
	{
		int tmp = a;
		a = b;
		b = tmp;
	}
}
class Program
{
	static void Main()
	{
		Console.Write("Enter a: ");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter b: ");
		int b = Convert.ToInt32(Console.ReadLine());
		Swap fo = new Swap();
		fo.foo(ref a, ref b);
		Console.WriteLine($"a: {a}\nb: {b}");
	}
}

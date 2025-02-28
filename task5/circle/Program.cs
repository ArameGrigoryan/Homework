using System;

class Area
{
	const double p = 3.14159;
	private double Perimeter(double radius)
	{
		return (2 * p * radius);
	}
	private double Circle(double radius)
	{
		return (p * (radius * radius));
	}
	public void Run()
	{
		Console.Write("Enter radius for area: ");
		double radius = double.Parse(Console.ReadLine());
		if (radius <= 0) 
		{
			Console.WriteLine("invalid argument!");
			return;
		}
		Console.WriteLine("Perimeter: {0}\nCircul: {1}", Perimeter(radius), Circle(radius));
	}
}
class Program
{
	static void Main()
	{
		Area area = new Area();
		area.Run();
	}
}

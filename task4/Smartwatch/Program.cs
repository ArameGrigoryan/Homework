using System;
class Smartwatch
{
	private string _name;
	private int _steps;
	public void AddSteps(int Steps) 
	{
		_steps += Steps;
		Console.WriteLine($"Your total number of steps: {_steps}");
	}
}
class Program
{
	static void Main()
	{
		Smartwatch Watch = new Smartwatch();
		Console.WriteLine("Hello client...");
		while (true)
		{
			Console.Write("How many hours to walk(Enter -1 for exit): ");
			int time = Convert.ToInt32(Console.ReadLine());
			if (time == -1) 
			{
				break;
			}
			Watch.AddSteps(time * 5000);
		}
	}
}

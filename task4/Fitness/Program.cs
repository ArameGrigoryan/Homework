using System;

class Fitness
{
	string _exercis;
	double _duration;
	public Fitness(string Exercis, double Duration)
	{
		_exercis = Exercis;
		_duration = Duration;
	}
	public void ShowWorkoutDetails()
	{
		Console.WriteLine($"Exercis: {_exercis}\nDuration in minuts: {_duration}");
	}
}
class Program
{
	static void Main()
	{
		Fitness[] fitnes = new Fitness[3];
		for (int i = 0; i < 3; ++i) 
		{
			Console.Write("Enter exercis: ");
			string? exercis = Console.ReadLine();
			Console.Write("Enter duration in minuts: ");
			double time = double.Parse(Console.ReadLine());
			fitnes[i] = new Fitness(exercis, time);
		}
		Console.WriteLine("<------------->");
		for (int i = 0; i < 3; ++i) 
		{
			fitnes[i].ShowWorkoutDetails();
		}
	}
}

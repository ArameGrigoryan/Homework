using System;

class Temperature
{
	private void Faringate(out double faringate, int celsuse)
	{
		faringate = ((celsuse * 9 / 5) + 32);
	}
	public void Run()
	{
		Console.Write("Enter celsius: ");
		int celsiuse = int.Parse(Console.ReadLine());
		double faringate;
		Faringate(out faringate, celsiuse);
		Console.WriteLine("Result is: {0}", faringate);
	}
}
class Program
{
	static void Main()
	{

		Temperature temp = new Temperature();
		temp.Run();
	}
}

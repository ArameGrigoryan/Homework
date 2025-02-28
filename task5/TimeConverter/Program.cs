using System;

class TimeConverter
{
	private int _totalSecunds;
	public TimeConverter(int secunds)
	{
		_totalSecunds = secunds;
	}
	public void Time(ref int hours, ref int minuts, ref int secunds)
	{
		minuts = _totalSecunds / 60;
		_totalSecunds %= 60;
		hours = minuts / 60;
		minuts %= 60;
		secunds = _totalSecunds;
	}
}
class Program
{
	static void Main()
	{
		Console.Write("Enter secunds: ");
		int secund = Convert.ToInt32(Console.ReadLine());
		TimeConverter time = new TimeConverter(secund);
		int hours = 0;
		int minuts = 0;
		time.Time(ref hours, ref minuts, ref secund);
		Console.WriteLine("hours: {0}\nminuts: {1}\nsecunds: {2}", hours, minuts, secund);
	}
}

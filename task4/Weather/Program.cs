using System;

class WeatherReport
{
	private string _city;
	private int _temperature;
	private int _humidity;
	private string _condition;

	public WeatherReport(string City, int Temperature, int Humidity, string Condition)
	{
		_city = City;
		_temperature = Temperature;
		_humidity = Humidity;
		_condition = Condition;
	}
	public void GetWeaterInfo()
	{
		Console.WriteLine($"In city: {_city}\nTemperature: {_temperature}\nHumidity: {_humidity}%\nCondition: {_condition}");
	}
	public static string Werther(int Temperature)
	{
		if (Temperature < -10)
		{
			return "Winter";
		}
		else if (Temperature > -10 && Temperature < 0)
		{
			return "Spring";
		}
		else if (Temperature > 0 && Temperature < 10)
		{
			return "Othem";
		}
		return "Summary";
	}
}
class Program
{
	static void Main()
	{
		Random rand = new Random();
		Console.WriteLine("Hello client...");
		WeatherReport[] reports = new WeatherReport[3];
		for (int i = 0; i < 3; ++i) 
		{
			Console.WriteLine("Enter city name: ");
			string? Sity = Console.ReadLine();
			int Temperature = rand.Next(-50, 50);
			reports[i] = new WeatherReport(Sity, Temperature, rand.Next(0, 100), WeatherReport.Werther(Temperature));
		}
		for (int i = 0; i < 3; ++i)
		{
			reports[i].GetWeaterInfo();
		}
	}
}

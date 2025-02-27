using System;

public  class Car
{
	private string _model;
	public string CarModel 
	{
		get { return _model; }
		set { _model = value; }
	}
	private int _year;
	public int CarYear 
	{
		get { return _year; }
		set { _year = value; }
	}
	private bool _rented;
	public bool CarRented 
	{
		get { return _rented; }
		set { _rented = value; }
	}
	public Car(string model, int year) {
		CarModel = model;
		CarYear = year;
	}
	public void RentCar() 
	{
		CarRented = true;
	}
	public void ReturnCar() 
	{
		CarRented = false;
	}
	public void display() {
		string condition = (_rented == true)?"Yes":"No";
		Console.WriteLine($"model is -> {_model}\nyear is -> {_year}\nThe car is parked?:{condition}");
	}
}
class Program {
	static void Main() {
		Car[] cars = new Car[5];
		Console.WriteLine("Hello client...");
		for (int i = 0; i < 5; ++i) 
		{
			Console.Write("Enter the car model: ");
			string? name = Console.ReadLine();
			Console.Write("Enter the year of manufacture: ");
			int year = Convert.ToInt32(Console.ReadLine());
			cars[i] = new Car(name, year);
		}
		while (true) 
		{
			Console.Write("Do you want to rent a car(Yes/No)?: ");
			if (Console.ReadLine() == "No") 
			{
				Console.Write("Do you want to return the car?(Yes/No)");
				if (Console.ReadLine() == "Yes") 
				{
					Console.Write("Enter model for car: ");
					string? model = Console.ReadLine();
					for (int i = 0; i < 5; ++i) {
						if (model == cars[i].CarModel) 
						{
							cars[i].ReturnCar();
							Console.WriteLine("Thenc you claent good by");
							return;
						}
					}
				}
				else {
					Console.WriteLine("thenk you claent. Good by");
					return;
				}
			}
			for (int i = 0; i < 5; ++i) 
			{
				Console.WriteLine($"---Car{i}---");
				cars[i].display();
			}
			while (true) 
			{
				Console.Write("Do you want the car and take it?: ");
				string? model = Console.ReadLine();
				int flag = 0;
				for (int i = 0; i < 5; ++i) 
				{
					if (model == cars[i].CarModel && cars[i].CarRented == false) {
						cars[i].RentCar();
						Console.WriteLine("You have successfully rented this car! ");
						flag = 1;
						break;
					}
					else if (model == cars[i].CarModel && cars[i].CarRented == true) {
						Console.WriteLine("This car is already rented!");
						flag = 1;
						break;
					}
				}
				if (flag != 1) {
					Console.WriteLine("invalid model");
				}
				Console.Write("Do you want to continue?(Yes/No)");
				if (Console.ReadLine() == "No") {
					break;
				}
			}
		}
	}
}

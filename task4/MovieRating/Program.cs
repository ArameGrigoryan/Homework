using System;

class Movie
{
	private double _rating;
	public double Rating
	{
		get { return _rating; }
		set {
			if ((value < 0) || (value > 5))
			{
				Console.WriteLine("invalid rating!");
			}
			else {
				_rating = value;
			}
		}
	}
	public void GetReatingInfo()
	{
		Console.WriteLine($"Film rating: 5/{Rating}");
	}
}
class Program
{
	static void Main()
	{
		Movie film = new Movie();
		Console.Write("Enter reating for film Titanic: ");
		film.Rating = Convert.ToInt32(Console.ReadLine());
		
		film.GetReatingInfo();
	
	}
}

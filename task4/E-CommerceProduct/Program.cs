using System;

class Product
{
	private string _name;
	private int _price;
	private int _count;
	public Product(string Name, int Price, int Count)
	{
		_name = Name;
		_price = Price;
		_count = Count;
	}
	public void ShowInfoProduct()
	{
		Console.WriteLine($"Product: {_name}\nPrice: {_price}\nCount: {_count}");
	}
}
class Program
{
	static void Main()
	{
		Product[] products = new Product[3];
		for (int i = 0; i < 3; ++i) 
		{
			Console.Write("Enter product name: ");
			string? name = Console.ReadLine();
			Console.Write("Enter product price: ");
			int price = Convert.ToInt32(Console.ReadLine());
			products[i] = new Product(name, price, 10);
		}
		for (int i = 0; i < 3; ++i)
		{
			Console.WriteLine("<--------->")
			products[i].ShowInfoProduct();
		}
	}
}

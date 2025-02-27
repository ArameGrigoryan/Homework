using System;

partial class Product
{
	public Product(string Name, int Level)
	{
		this.Name = Name;
		this.Level = Level;
	}
	public void ShowCharacterInfo()
	{
		Console.WriteLine($"Name: {Name}\nLevel: {Level}");
	}
}
class Program
{
	static void Main()
	{
		Product prod = new Product("Watch", 10);
		prod.ShowCharacterInfo();
	}
}

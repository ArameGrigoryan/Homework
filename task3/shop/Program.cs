using System;

public class Product {
	public string name;
	double price;
	public Product (string name, double price){
		this.name = name;
		this.price = price;
	}
	public double TotalPrice(int count) {
		return this.price * count;
	}
}
class Shop {
	double total_price = 0;
	int count = 0;
	public void add_product(double price, int count) {
		total_price += price;
		this.count += count;
	}
	public double ret_price() {
		if (this.count > 4) {
			double tmp = (total_price * 10) / 100;
			total_price -= tmp;
			return total_price;
		}
		return total_price;
	}

}

class Program {
	static void Main() {
		Product[] arr = new Product[5];
		Shop res = new Shop();
		for (int i = 0; i < 5; ++i) {
			Console.Write($"Enter name of product{i}: ");
			string name = Console.ReadLine();
			Console.Write($"Enter price for product{i}: ");
			double price = double.Parse(Console.ReadLine());
			arr[i] = new Product(name, price);
		}
		string? com = null;
		Console.WriteLine("\thello my program have command\n1)add\n2)sum\n");
		while (true) {
			int flag = 0;
			Console.Write("Enter command: ");
			com = Console.ReadLine();
			if (com == "add") {
				for (int i = 0; i < 5; ++i) {
					Console.WriteLine($"{i + 1}){arr[i].name}");
				}
				Console.Write("Enter product: ");
				string? name = Console.ReadLine();
				for (int i = 0; i < 5; ++i) {
					if (name == arr[i].name) {
						Console.Write("Enter count: ");
						int count = Convert.ToInt32(Console.ReadLine());
						double total = arr[i].TotalPrice(count);
						res.add_product(total, count);
						flag = 1;
					}
				}
				if (flag != 1) {
					Console.WriteLine("invalid name of product");
					continue;
				}
			}
			else if (com == "sum") {
				Console.WriteLine("sum is -> {0}", res.ret_price());
				break;
			}
			else {
				Console.WriteLine("invalid command!");
				continue;
			}
		}
	}
}

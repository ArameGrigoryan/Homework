using System;
public class Bank {
	string? Number = null;
	string? name = null;
	double balance = 0;
	//constructer
	public Bank(string Number, string name) {
		this.Number = Number;
		this.name = name;
	}
	//add balance
	public bool Deposit(double money) {
		if (Double.MaxValue > money + this.balance) {
			this.balance += money;
			return true;
		}
		else {
			return false;
		}
	}
	//sub balance
	public bool WithDraw(double money) {
		if (money < this.balance) {
			this.balance -= money;
			return true;
		}
		else {
			return false;
		}
	}
	public void print() {
		Console.WriteLine($"your balance: {balance}");
	}
}
class Program {
	static void Main() {
		Console.Write("\t\tHello claent\nEnter your name:");
		string? name = Console.ReadLine();
		string? number = null;
		do {
			Console.Write("Enter number for balance(8 simbols): ");
			number = Console.ReadLine();
		} while (number.Length < 8);
		Bank client = new Bank(number, name);
		while (true) {
			Console.Write("Enter command add money in balance or sub: ");
			string? com = Console.ReadLine();
			if (com == "exit") {
				break;
			}
			else if (com == "add") {
				double money = 0;
				while (true) {
					Console.Write("Enter count for deposit: ");
					money = double.Parse(Console.ReadLine());
					if (client.Deposit(money) == true) {
						break;
					}
					Console.WriteLine("your balance filled");
				}
			}
			else if (com == "sub") {
				double money = 0;
				Console.Write("Enter count for deposit: ");
				money = double.Parse(Console.ReadLine());
				if (client.WithDraw(money) == false) { 
					Console.WriteLine("in your balance not enough money");
				}
			}
			else if (com == "print") {
				client.print();
			}
			else {
				Console.WriteLine("commond not fund");
			}
		}
	}
}

using System;

public class Obj {
	public string name;
	public string emile;
	public int number;

	public Obj(string num, string em, int numbr) {
		name = num;
		emile = em;
		number = numbr;
	}
}
class Program {
	static void Main(){
		Console.WriteLine("\n\t\thello my command is ---> add -- print -- sorch -- exit <---");
		string? com = null;
		Obj[] ob = new Obj[3];
		int count = 0;
		while (true) {
			Console.Write("\nEnter command: ");
			com = Console.ReadLine();
			if (com == "exit") {
				break;
			}
			else if (com == "print") {
				if (count == 0) {
					Console.WriteLine("contact empty!");
					continue;
				}
				print(ob, count);	
			}
			else if (com == "add") {
				if (count == 3) {
					Console.WriteLine("contact fillid");
					continue;
				}
				Console.Write("\n\tEnter name: ");
				string? nums = Console.ReadLine();
				Console.Write("\n\tEnter phone number: ");
				int num = Convert.ToInt32(Console.ReadLine());
				string? emil = secur();

				ob[count++] = new Obj(nums, emil, num);
			}
			else if (com == "sorch") {
				if (count == 0) {
					Console.WriteLine("Contact empty");
					continue;
				}
				Console.Write("\nEnter nume for contact: ");
				string? name = Console.ReadLine();
				int i = 0;
				for (; i < count; ++i) {
					if (name == ob[i].name) {
						Console.WriteLine($"\nname: {ob[i].name}\nphone number: {ob[i].number}\nemile: {ob[i].emile}");
						break;
					}
				}
				if (i == count) {
					Console.WriteLine("contact not fund");
				}
			}
			else {
				Console.WriteLine("invalid command");
				continue;
			}

		}
	}
	public static void print(Obj[] ob, int count) {
		for (int i = 0; i < count; ++i) {
			Console.WriteLine($"\nname is: {ob[i].name}\nnumber is: {ob[i].number}\nemile is: {ob[i].emile}");
		}
	}
	public static string secur() {
		string? emile = null;
		while (true) {
			Console.Write("\n\tenter emile: ");
			emile = Console.ReadLine();
			if ((emile.IndexOf("@gmail.com")) > 0) {
				return emile;
			}
			Console.WriteLine("invalid emile!");
		}
	}
}
